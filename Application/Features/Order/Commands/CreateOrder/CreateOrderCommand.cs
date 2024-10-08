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

namespace Application.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
       
        public List<OrderItemDto>  OrderItems { get; set; }
       

        public class CreatedOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderRepository _orderRepository;
            private readonly IProductRepository _productRepository;

            public CreatedOrderCommandHandler(IOrderRepository orderRepository, IHttpContextAccessor httpContextAccessor, IProductRepository productRepository)
            {
                _orderRepository = orderRepository;
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
            }

            public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                var customerId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                if (customerId == null)
                {
                    throw new Exception("Kullanıcı bulunamadı");
                    
                }
                decimal totalAmount = 0;

                var orderDetails = new List<OrderDetail>();

                foreach (var item in request.OrderItems)
                {
                    var product = await _productRepository.GetByIdAsync(item.ProductId);
                    if (product == null)
                    {
                        throw new Exception($"Product with ID {item.ProductId} not found.");
                    }

                    totalAmount += product.Price * item.Quantity;

                    orderDetails.Add(new Domain.Entities.OrderDetail
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = product.Price // Burada, fiyatın güncel durumunu yansıtıyor olmalısınız
                    });
                }

                var order = new Domain.Entities.Order
                {
                    CustomerId = customerId,
                    OrderDate = DateTime.UtcNow,
                    TotalAmount = totalAmount,
                    OrderDetails = orderDetails,
                    OrderStatusId = 1 // Sipariş durumu burada sabit, dinamik olmalı
                };

                // Siparişi veritabanına kaydet
                await _orderRepository.AddAsync(order);

                return new CreateOrderCommandResponse
                {
                    OrderId = order.Id,
                    CreatedDate = order.OrderDate ?? DateTime.Now,
                    Status = "Success"
                };
            }
        }
    }
}
