using Application.Features.Order.DTOS;
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
            private readonly IOrderStatusRepository _orderStatusRepository;
            public CancelOrderCommandHandler(IHttpContextAccessor httpContextAccessor, IOrderRepository orderRepository, IUserRepository userRepository, IOrderStatusRepository orderStatusRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderRepository = orderRepository;
                _userRepository = userRepository;
                _orderStatusRepository = orderStatusRepository;
            }

            public async Task<CancelOrderCommandResponse> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
            {
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

                if (userId == null)
                {
                    throw new Exception("Kullanıcı bulunamadı");
                }

                var order = await _orderRepository.GetByIdAsync(request.OrderId);
                if (order == null) { 
                    
                    return new CancelOrderCommandResponse { 
                    
                        Success = false,
                        Message ="Sipariş Bulunamadı"
                    };
                
                }

                //Yetki
                if (order.CustomerId != userId)
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
                await _orderRepository.UpdateAsync(order);

                return new CancelOrderCommandResponse
                {
                    Success = true,
                    Message = "Sipariş başarıyla iptal edildi.",
                    CancelledOrder = new OrderDto // İptal edilen siparişin bilgileri
                    {
                        OrderId = order.Id,
                        OrderStatusId = order.OrderStatusId
                        
                    }
                };
            }
        }
    }
}
