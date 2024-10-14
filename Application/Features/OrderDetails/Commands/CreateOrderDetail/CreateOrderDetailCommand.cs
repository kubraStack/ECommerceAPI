using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Commands.CreateOrderDetail
{
    public class CreateOrderDetailCommand : IRequest<CreateOrderDetailCommandResponse>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, CreateOrderDetailCommandResponse>
        {
            private readonly IOrderDetailRepository _orderDetailRepository;

            public CreateOrderDetailCommandHandler(IOrderDetailRepository orderDetailRepository)
            {
                _orderDetailRepository = orderDetailRepository;
            }

            public async Task<CreateOrderDetailCommandResponse> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
            {
                var orderDetail = new Domain.Entities.OrderDetail
                {
                    OrderId = request.OrderId,
                    ProductId = request.ProductId,
                    Quantity = request.Quantity,
                    Price = request.UnitPrice
                };

                await _orderDetailRepository.AddAsync(orderDetail);

                return new CreateOrderDetailCommandResponse
                {
                    Success = true,
                    Message = "Sipariş Detayı Başarıyla Oluşturuldu.",
                    OrderDetailId = request.OrderId
                };
            }
        }
    }
}
