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
                // Kullanıcı rolünü almak için HttpContextAccessor kullanıyoruz
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                // Eğer kullanıcı admin ise, tüm siparişleri al
                if (userRole == "Admin")
                {
                    var orders = await _orderRepository.GetListAsync();

                    var orderDtos = orders.Select(order => new OrderDto
                    {
                        OrderId = order.Id,
                        OrderDate = (DateTime)order.OrderDate,
                        TotalAmount = order.TotalAmount,
                        OrderStatusId = order.OrderStatusId,
                    }).ToList();

                    return new GetAllOrdersQueryResponse
                    {
                        Orders = orderDtos
                    };
                }

                // Eğer kullanıcı customer ise, sadece kendi siparişlerini al
                var customerOrders = await _orderRepository.GetListAsync(order => order.CustomerId.ToString() == userId);

                var customerOrderDtos = customerOrders.Select(order => new OrderDto
                {
                    OrderId = order.Id,
                    OrderDate = (DateTime)order.OrderDate,
                    TotalAmount = order.TotalAmount,
                    OrderStatusId = order.OrderStatusId,
                }).ToList();

                return new GetAllOrdersQueryResponse
                {
                    Orders = customerOrderDtos
                };
            }
        }
    }
}
