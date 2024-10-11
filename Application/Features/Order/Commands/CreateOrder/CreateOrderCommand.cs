using Application.Features.Order.DTOS;
using Application.Repositories;
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
        public int PaymentId { get; set; }
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

            public CreatedOrderCommandHandler(IOrderRepository orderRepository, IHttpContextAccessor httpContextAccessor, IProductRepository productRepository, ICustomerRepository customerRepository)
            {
                _orderRepository = orderRepository;
                _httpContextAccessor = httpContextAccessor;
                _productRepository = productRepository;
                _customerRepository = customerRepository;
            }

            public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);
                int? customerId = null;

                if (userIdClaim != null)
                {
                    var userId = int.Parse(userIdClaim.Value);

                    // Kullanıcı ID'sine göre müşteri kaydını alın
                    var customer = await _customerRepository.GetByUserIdAsync(userId); // UserId'ye göre al

                    if (customer != null)
                    {
                        customerId = customer.Id; // Müşteri ID'sini al
                    }
                }

                // Yeni Order oluşturun
                var order = new Domain.Entities.Order
                {
                    CustomerId = customerId, // Eğer müşteri yoksa null olacak
                    PaymentId = request.PaymentId,
                    OrderDate = DateTime.UtcNow,
                    TotalAmount = 0,
                    OrderStatusId = 1,
                    GuestInfo = null // Varsayılan olarak null
                };

                // Misafir bilgilerini ayarlayın, eğer müşteri yoksa
                if (customerId == null)
                {
                    var guestInfo = new GuestInfoDto
                    {
                        GuestName = request.GuestName,
                        GuestEmail = request.GuestEmail,
                        GuestPhone = request.GuestPhone,
                        GuestAddress = request.GuestAddress
                    };

                    // Misafir bilgilerini JSON formatında saklayın
                    order.GuestInfo = JsonSerializer.Serialize(guestInfo);
                }

                decimal totalAmount = 0;
                // OrderDetails koleksiyonunun null olup olmadığını kontrol edin
                if (order.OrderDetails == null)
                {
                    order.OrderDetails = new List<OrderDetail>();
                }

                // OrderItems null olup olmadığını kontrol edin
                if (request.OrderItems == null)
                {
                    throw new BusinessException("Order items cannot be null.");
                }
                foreach (var item in request.OrderItems)
                {
                    var product = await _productRepository.GetByIdAsync(item.ProductId);
                    if (product != null)
                    {
                        var orderDetail = new OrderDetail
                        {
                            ProductId = product.Id,
                            Quantity = item.Quantity,
                            Price = product.Price // Ürün fiyatını ayarlayın
                        };

                        order.OrderDetails.Add(orderDetail); // OrderDetails koleksiyonuna ekleyin

                        // Toplam tutarı hesaplayın
                        totalAmount += product.Price * item.Quantity; // Ürün fiyatı ile miktarı çarpın
                    }
                }

                // Toplam tutarı ayarla
                order.TotalAmount = totalAmount;

                // Siparişi veritabanına ekleyin
                await _orderRepository.AddAsync(order);

                // Yanıt nesnesini oluşturun
                var response = new CreateOrderCommandResponse
                {
                    Message = "Sipariş oluşturuldu",
                    OrderId = order.Id // Oluşturulan siparişin ID'si
                };

                return response;

            }
        }
    }
}
