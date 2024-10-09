using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
using Application.Repositories;
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

            public GetOrderByIdQueryHandler(IHttpContextAccessor httpContextAccessor, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderRepository = orderRepository;
                _orderDetailRepository = orderDetailRepository;
            }

            public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim == null || string.IsNullOrWhiteSpace(userIdClaim.Value))
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                var userId = userIdClaim.Value;

                //Sipariş
                var order = await _orderRepository.GetAsync(o => o.Id == request.OrderId && o.CustomerId.ToString() == userId);
                if (order == null)
                {
                    throw new Exception("Sipariş bulunamadı.");
                }

                //Dto'ya dönüştür
                var orderDto = new OrderDto
                {
                    OrderId = order.Id,
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
