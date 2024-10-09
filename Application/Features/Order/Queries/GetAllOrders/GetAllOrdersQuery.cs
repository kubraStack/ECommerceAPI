using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
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

namespace Application.Features.Order.Queries.GetAllOrders
{
    public class GetAllOrdersQuery : IRequest<GetAllOrdersQueryResponse>
    {
        public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, GetAllOrdersQueryResponse>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;


            public GetAllOrdersQueryHandler(IOrderRepository orderRepository, IHttpContextAccessor httpContextAccessor)
            {
                _orderRepository = orderRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetAllOrdersQueryResponse> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
            {
                // Kullanıcı rolünü ve ID'sini al
                var userRoleClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                
                // Kullanıcı ID'si kontrolü
                if (string.IsNullOrWhiteSpace(userIdClaim))
                {
                    throw new Exception("Kullanıcı ID'si bulunamadı.");
                }
                Console.WriteLine($"User Role: {userRoleClaim}"); // Loglama


                // Rol kontrolü
                if (string.IsNullOrWhiteSpace(userRoleClaim))
                {
                    throw new Exception("Kullanıcı rolü bulunamadı.");
                }

                // Kullanıcı rolüne göre siparişleri al
                if (userRoleClaim == "Admin")
                {
                    return await GetAllOrders();
                }
                else if (userRoleClaim == "Customer")
                {
                    return await GetCustomerOrders(userIdClaim);
                }
                else if (userRoleClaim == "Customer")
                {
                    return await GetCustomerOrders(userIdClaim);
                }

                else
                {
                    throw new Exception("Geçersiz kullanıcı rolü.");
                }

            }

            private async Task<GetAllOrdersQueryResponse> GetAllOrders()
            {
                var orders = await _orderRepository.GetListAsync();

                var orderDtos = orders.Select(order => new OrderDto
                {
                    OrderId = order.Id,
                    OrderDate = order.OrderDate ?? DateTime.Now, // Null kontrolü
                    TotalAmount = order.TotalAmount,
                    OrderStatusId = order.OrderStatusId,
                    OrderDetails = order.OrderDetails?.Select(detail => new OrderDetailDto
                    {
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.Price
                    }).ToList() ?? new List<OrderDetailDto>()
                }).ToList();

                return new GetAllOrdersQueryResponse
                {
                    Orders = orderDtos
                };
            }

            private async Task<GetAllOrdersQueryResponse> GetCustomerOrders(string userId)
            {
                var customerOrders = await _orderRepository.GetListAsync(order => order.CustomerId == Convert.ToInt32(userId));

                if (customerOrders == null || !customerOrders.Any())
                {
                    throw new Exception("Siparişler bulunamadı.");
                }

                var customerOrderDtos = customerOrders.Select(order => new OrderDto
                {
                    OrderId = order.Id,
                    CustomerId = (int)order.CustomerId,
                    OrderDate = order.OrderDate ?? DateTime.Now, // Null kontrolü
                    TotalAmount = order.TotalAmount,
                    OrderStatusId = order.OrderStatusId,
                    OrderDetails = order.OrderDetails?.Select(detail => new OrderDetailDto
                    {
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.Price
                    }).ToList() ?? new List<OrderDetailDto>()
                }).ToList();

                return new GetAllOrdersQueryResponse
                {
                    Orders = customerOrderDtos
                };
            }
        }
        
    }
}
