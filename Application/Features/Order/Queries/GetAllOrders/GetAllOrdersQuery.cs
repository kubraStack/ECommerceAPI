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
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim == null || string.IsNullOrWhiteSpace(userIdClaim.Value))
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                var userId = userIdClaim.Value;

                // Kullanıcı rolüne göre siparişleri al
                if (userRole == "Admin")
                {
                    return await GetAllOrders();
                }
                else if (userRole == "Customer")
                {
                    return await GetCustomerOrders(userId);
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
                var customerOrders = await _orderRepository.GetListAsync(order => order.CustomerId.ToString() == userId);

                if (customerOrders == null || !customerOrders.Any())
                {
                    throw new Exception("Siparişler bulunamadı.");
                }

                var customerOrderDtos = customerOrders.Select(order => new OrderDto
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
                    Orders = customerOrderDtos
                };
            }
        }
    }
}
