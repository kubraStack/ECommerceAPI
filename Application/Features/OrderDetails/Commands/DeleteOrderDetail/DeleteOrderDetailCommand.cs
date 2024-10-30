using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Commands.DeleteOrderDetail
{
    public class DeleteOrderDetailCommand : IRequest<DeleteOrderDetailCommandResponse>
    {
        public int OrderDetailId { get; set; }

        public DeleteOrderDetailCommand(int orderDetailId)
        {
            OrderDetailId = orderDetailId;
        }

        public class DeleteOrderDetailCommandHandler : IRequestHandler<DeleteOrderDetailCommand, DeleteOrderDetailCommandResponse>
        {
            private readonly IOrderDetailRepository _orderDetailRepository;

            public DeleteOrderDetailCommandHandler(IOrderDetailRepository orderDetailRepository)
            {
                _orderDetailRepository = orderDetailRepository;
            }

            public async Task<DeleteOrderDetailCommandResponse> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
            {
                var orderDetail = await _orderDetailRepository.GetByIdAsync(request.OrderDetailId);
                if (orderDetail == null) 
                {
                    return new DeleteOrderDetailCommandResponse(false, "Order Detail not found");
                }

                await _orderDetailRepository.DeleteAsync(orderDetail);
                return new DeleteOrderDetailCommandResponse(true, "Order Detail deleted successfully");
            }
        }
    }
}
