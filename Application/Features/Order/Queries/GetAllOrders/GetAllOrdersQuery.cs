using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
using Application.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Queries.GetAllOrders
{
    public class GetAllOrdersQuery : IRequest<GetAllOrdersQueryResponse>
    {
        public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, GetAllOrdersQueryResponse>
        {
            private readonly IOrderRepository _orderRepository;

            public GetAllOrdersQueryHandler(IOrderRepository orderRepository)
            {
                _orderRepository = orderRepository;
            }

            public async Task<GetAllOrdersQueryResponse> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
            {
                var orders = await _orderRepository.GetListAsync();

                //OrderDto'ya dönüştürme
                var orderDtos = orders.Select(order => new OrderDto
                {
                    OrderId = order.Id,
                    OrderDate = (DateTime)order.OrderDate,
                    TotalAmount = order.TotalAmount,
                    OrderStatusId = order.OrderStatusId, // Eğer OrderDto'da statusId eklediyseniz
                   
                }).ToList();

                return new GetAllOrdersQueryResponse
                {
                    Orders = orderDtos // OrderDto listesini yanıt nesnesine ekleyin
                };
            }
        }
    }
}
