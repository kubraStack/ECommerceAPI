using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderStatus.Commands.UpdateOrderStatusCommand
{
    public class UpdateOrderStatusCommand : IRequest<UpdateOrderStatusCommandResponse>, ISequredRequest
    {
        public int OrderId { get; set; }
        public int NewStatusId { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommand, UpdateOrderStatusCommandResponse>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IOrderStatusRepository _orderStatusRepository;

            public UpdateOrderStatusCommandHandler(IOrderRepository orderRepository, IOrderStatusRepository orderStatusRepository = null)
            {
                _orderRepository = orderRepository;
                _orderStatusRepository = orderStatusRepository;
            }

            public async Task<UpdateOrderStatusCommandResponse> Handle(UpdateOrderStatusCommand request, CancellationToken cancellationToken)
            {
               var order = await _orderRepository.GetByIdAsync(request.OrderId);
                if (order == null)
                {
                    throw new Exception("Order not found");
                }

                //Mevcut durum
                if (order.OrderStatus.Name != "Pending")
                {
                    throw new Exception("Order can only be approved from 'Pending' status.");
                }


                //Yeni Durum
                var newStatus = await _orderStatusRepository.GetByIdAsync(request.NewStatusId);
                if (newStatus == null) {
                    throw new Exception("Invalid status Id");
                }

                order.OrderStatus = newStatus;

                await _orderRepository.UpdateAsync(order);
                return new UpdateOrderStatusCommandResponse
                {
                    OrderId = request.OrderId,
                    NewStatusName = newStatus.Name,
                    Message = "Order Status is  updated",
                    UpdatedDate = DateTime.UtcNow
                };
            }
        }
    }
}
