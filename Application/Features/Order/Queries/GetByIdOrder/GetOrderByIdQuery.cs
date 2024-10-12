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

namespace Application.Features.Order.Queries.GetByIdOrder
{
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResponse>
    {
        public int OrderId { get; set; }

        public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderRepository _orderRepository;
            private readonly IOrderDetailRepository _orderDetailRepository;
            private readonly ICustomerRepository _customerRepository;

            public GetOrderByIdQueryHandler(IHttpContextAccessor httpContextAccessor, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, ICustomerRepository customerRepository = null)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderRepository = orderRepository;
                _orderDetailRepository = orderDetailRepository;
                _customerRepository = customerRepository;
            }

            public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim == null || string.IsNullOrWhiteSpace(userIdClaim.Value))
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                var userId = int.Parse(userIdClaim.Value);
                var userRoleClaim = _httpContextAccessor.HttpContext.User.FindFirst("UserType")?.Value;

                Domain.Entities.Order order;
                if (userRoleClaim == "Admin")
                {
                    order = await _orderRepository.GetAsync(o => o.Id == request.OrderId);
                }
                else
                {
                    var customer = await _customerRepository.GetAsync(c => c.UserId == userId);
                    if (customer == null)
                    {
                        throw new Exception("Müşteri bilgileri bulunamadı.");
                    }
                    order = await _orderRepository.GetAsync( o => o.Id == request.OrderId && o.CustomerId == customer.Id); 
                }
                if (order == null)
                {
                    throw new Exception("Sipariş bulunamadı.");
                }

                //Dto'ya dönüştür
                var orderDto = new OrderDto
                {
                    OrderId = order.Id,
                    CustomerId = order.CustomerId ?? 0,
                    GuestInfo = order.GuestInfo,
                    OrderDate = order.OrderDate ?? DateTime.Now, //Nul Kontrolü
                    TotalAmount = order.TotalAmount,
                    OrderStatusId = order.OrderStatusId,
                    OrderDetails = order.OrderDetails?.Select(detail => new OrderDetails.DTOS.OrderDetailDto
                    {
                        ProductId = detail.ProductId,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.Price
                    }).ToList() ?? new List<OrderDetailDto>(),
                };
                return new GetOrderByIdQueryResponse
                {
                    Order = orderDto
                };
            }
        }
    }
}
