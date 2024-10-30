using Application.Abstracts;
using Application.Features.Order.DTOS;
using Application.Features.Payment.Commands.DeletePayment;
using Application.Features.Payment.Commands.UpdatePayment;
using Application.Repositories;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.CancelOrder
{
    public class CancelOrderCommand : IRequest<CancelOrderCommandResponse>
    {
        public int OrderId { get; set; }


        public class CancelOrderCommandHandler : IRequestHandler<CancelOrderCommand, CancelOrderCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderRepository _orderRepository;
            private readonly IUserRepository _userRepository;
            private readonly ICustomerRepository _customerRepository;
            private readonly IOrderStatusRepository _orderStatusRepository;
            private readonly IPaymentRepository _paymentRepository;
            private readonly IMediator _mediator;
            private readonly IMailService _mailService;
            public CancelOrderCommandHandler(IHttpContextAccessor httpContextAccessor, IOrderRepository orderRepository, IUserRepository userRepository, IOrderStatusRepository orderStatusRepository, IMediator mediator = null, IPaymentRepository paymentRepository = null, ICustomerRepository customerRepository = null, IMailService mailService = null)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderRepository = orderRepository;
                _userRepository = userRepository;
                _orderStatusRepository = orderStatusRepository;
                _mediator = mediator;
                _paymentRepository = paymentRepository;
                _customerRepository = customerRepository;
                _mailService = mailService;
            }

            public async Task<CancelOrderCommandResponse> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
            {
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                
                var user = await _userRepository.GetByIdAsync(userId);
                if (user == null) {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

               var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null) {
                    throw new Exception("Müşteri bulunamadı.");
                }
                var isGuestUser = customer == null;

                var order = await _orderRepository.GetByIdAsync(request.OrderId);
                if (order == null) { 
                    
                    return new CancelOrderCommandResponse { 
                    
                        Success = false,
                        Message ="Sipariş Bulunamadı"
                    };
                
                }
           
                if (!isGuestUser && order.CustomerId != customer.Id)
                {
                    return new CancelOrderCommandResponse
                    {
                        Success = false,
                        Message = "Bu siparişi iptal etme yetkiniz yok."
                    };
                }

                var orderStatuses = await _orderStatusRepository.GetListAsync();
                var pendingStatus = orderStatuses.FirstOrDefault(status => status.Name.Equals("Pending"));
                var cancelledStatus = orderStatuses.FirstOrDefault(status => status.Name.Equals("Cancelled")); 
                if (pendingStatus == null || cancelledStatus == null)
                {
                    return new CancelOrderCommandResponse
                    {
                        Success = false,
                        Message = "Sipariş durumları bulunamadı."
                    };
                }

                if (order.OrderStatusId != pendingStatus.Id)
                {
                    return new CancelOrderCommandResponse
                    {
                        Success = false,
                        Message = "Bu siparişi iptal edemezsiniz."
                    };
                }

                //İptal İşlemi
                order.OrderStatusId = cancelledStatus.Id;

                var payment = await _paymentRepository.GetByIdAsync(order.PaymentId);
                if (payment == null)
                {
                    throw new Exception("Ödeme bulunamadı");
                }
                var updatePaymentCommand = new UpdatePaymentCommand
                {
                    PaymentId = order.PaymentId,
                    Amount = 0, 
                    PaymentMethodId = payment.PaymentMethodId,
                    Status = PaymentStatus.Cancelled
                };

                var paymentResponse = await _mediator.Send(updatePaymentCommand, cancellationToken);
                if (paymentResponse == null || !paymentResponse.Success)
                {
                    throw new Exception("Ödeme güncellenirken bir hata oluştu.");
                }

                await _orderRepository.UpdateAsync(order);

                var emailToNotify = customer.User.Email; 
                var subject = "Sipariş İptal Edildi"; 
                var body = $"Siparişiniz (ID: {order.Id}) başarıyla iptal edilmiştir.";
                if (isGuestUser)
                {
                    // Misafir kullanıcının bilgileri sipariş bilgileri içinde saklanmalı
                    var guestEmail = order.GuestInfo; // Misafirin e-posta adresini buradan almalısınız
                    emailToNotify = guestEmail; // Misafirin e-posta adresi
                }
                else
                {
                    emailToNotify = customer.User.Email; // Kullanıcının e-posta adresi
                }
                await _mailService.SendOrderConfirmationEmailAsync(emailToNotify, subject, body, order.Id.ToString());

                return new CancelOrderCommandResponse
                {
                    Success = true,
                    Message = "Sipariş başarıyla iptal edildi.",
                    CancelledOrder = new OrderDto 
                    {
                        OrderId = order.Id,
                        OrderStatusId = order.OrderStatusId
                        
                    }
                };
            }
        }
    }
}
