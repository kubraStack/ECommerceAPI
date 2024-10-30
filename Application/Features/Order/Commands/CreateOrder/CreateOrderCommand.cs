﻿using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.Commands.CreateOrderDetail;
using Application.Features.Payment.Commands.CreatePayment;
using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
       
        public List<OrderItemDto>  OrderItems { get; set; }
        public int PaymentMethodId { get; set; }
        public string   GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string GuestPhone { get; set; }
        public string GuestAddress { get; set; }
      
        public class CreatedOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderRepository _orderRepository;
            private readonly IProductRepository _productRepository;
            private readonly ICustomerRepository _customerRepository;
           private readonly IMediator _mediator;


            public CreatedOrderCommandHandler(IOrderRepository orderRepository, IHttpContextAccessor httpContextAccessor, IProductRepository productRepository, ICustomerRepository customerRepository, IMapper mapper = null, IMediator mediator = null)
            {
                _orderRepository = orderRepository;
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
                _customerRepository = customerRepository;
                _mediator = mediator;
            }

            public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);
                int? customerId = null;

                if (userIdClaim != null)
                {
                    var userId = int.Parse(userIdClaim.Value);
                    var customer = await _customerRepository.GetByUserIdAsync(userId); 

                    if (customer != null)
                    {
                        customerId = customer.Id; 
                    }
                }

               
                var order = new Domain.Entities.Order
                {
                    CustomerId = customerId, // Eğer müşteri yoksa null olacak
                   
                    OrderDate = DateTime.UtcNow,
                    TotalAmount = 0,
                    OrderStatusId = 1,
                    GuestInfo = null // Varsayılan olarak null
                };

                // Misafir bilgilerini ayarla, eğer müşteri yoksa
                if (customerId == null)
                {
                    // Misafir bilgileri kontrolü
                    if (string.IsNullOrWhiteSpace(request.GuestName) ||
                        string.IsNullOrWhiteSpace(request.GuestEmail) ||
                        string.IsNullOrWhiteSpace(request.GuestPhone) ||
                        string.IsNullOrWhiteSpace(request.GuestAddress))
                    {
                        throw new BusinessException("Misafir bilgileri eksik. Tüm alanların doldurulması gerekiyor.");
                    }

                    var guestInfo = new GuestInfoDto
                    {
                        GuestName = request.GuestName,
                        GuestEmail = request.GuestEmail,
                        GuestPhone = request.GuestPhone,
                        GuestAddress = request.GuestAddress
                    };
                    order.GuestInfo = JsonSerializer.Serialize(guestInfo);
                }

                decimal totalAmount = 0;
                await _orderRepository.AddAsync(order);

                if (order.OrderDetails == null)
                {
                    order.OrderDetails = new List<OrderDetail>();
                }

               
                if (request.OrderItems == null)
                {
                    throw new BusinessException("Order items cannot be null.");
                }

                foreach (var item in request.OrderItems)
                {
                    var product = await _productRepository.GetByIdAsync(item.ProductId);
                    if (product != null)
                    {
                        var createOrderDetailCommand = new CreateOrderDetailCommand
                        {
                            OrderId = order.Id,
                            ProductId = product.Id,
                            Quantity = item.Quantity,
                            UnitPrice = product.Price
                            
                        };

                        var orderDetailResponse = await _mediator.Send(createOrderDetailCommand, cancellationToken);
                        if (orderDetailResponse.Success)
                        {
                            totalAmount += product.Price * item.Quantity;
                        }
                    }
                }

                
                order.TotalAmount = totalAmount;
                await _orderRepository.UpdateAsync(order);

                var createPaymentCommand = new CreatePaymentCommand
                {
                    OrderId = order.Id,
                    Amount = totalAmount,
                    PaymentMethodId = request.PaymentMethodId,
                    PaymentStatus = PaymentStatus.Pending
                };
                var paymentResponse = await _mediator.Send(createPaymentCommand, cancellationToken);
                if (paymentResponse == null)
                {
                    throw new BusinessException("Ödeme işlemi sırasında bir hata oluştu.");
                }
                order.PaymentId = paymentResponse.PaymentId;
                await _orderRepository.UpdateAsync(order);

                var response = new CreateOrderCommandResponse
                {
                    Message = "Sipariş oluşturuldu",
                    OrderId = order.Id 
                };

                return response;

            }
        }
    }
}
