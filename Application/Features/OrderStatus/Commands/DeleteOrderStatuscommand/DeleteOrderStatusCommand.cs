using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderStatus.Commands.DeleteOrderStatuscommand
{
    public class DeleteOrderStatusCommand : IRequest<DeleteOrderStatusCommandResponse>, ISequredRequest
    {
        public DeleteOrderStatusCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class DeleteOrderStatusCommandHandler : IRequestHandler<DeleteOrderStatusCommand, DeleteOrderStatusCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderStatusRepository _orderStatusRepository;

            public DeleteOrderStatusCommandHandler(IHttpContextAccessor httpContextAccessor, IOrderStatusRepository orderStatusRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderStatusRepository = orderStatusRepository;
            }

            public async Task<DeleteOrderStatusCommandResponse> Handle(DeleteOrderStatusCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                if (userRole != "Admin")
                {
                    throw new Exception("Bu İşlemi Yapmaya Yetkiniz Yok.");
                }

                var orderStatus = await _orderStatusRepository.GetByIdAsync(request.Id);
                if (orderStatus == null) {
                    throw new Exception("Sipariş Durumu Bulunamadı.");
                }

                await _orderStatusRepository.DeleteAsync(orderStatus);

                return new DeleteOrderStatusCommandResponse
                {
                    Success = true,
                    Message = "Sipariş durumu başarıyla silindi."
                };

            }
        }
    }
}
