using Application.Features.Order.DTOS;
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

namespace Application.Features.OrderStatus.Commands.CreateOrderStatusCommand
{
    public class CreateOrderStatusCommand : IRequest<CreateOrderStatusCommandResponse>, ISequredRequest
    {
        public string StatusName { get; set; }
        public string Description { get; set; }

        public string[] RequiredRoles => ["Admin"];

        public class CreateOrderStatusCommandHandler : IRequestHandler<CreateOrderStatusCommand, CreateOrderStatusCommandResponse>
        {
            private readonly IOrderStatusRepository _orderStatusRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public CreateOrderStatusCommandHandler(IOrderStatusRepository orderStatusRepository, IHttpContextAccessor httpContextAccessor)
            {
                _orderStatusRepository = orderStatusRepository;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<CreateOrderStatusCommandResponse> Handle(CreateOrderStatusCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

                if (userRole != "Admin")
                {
                    throw new Exception("Kategori oluşturma yetkiniz yok.");
                }
                var orderStatus = new Domain.Entities.OrderStatus
               {
                   Name = request.StatusName,
                   Description = request.Description,
               };

                await _orderStatusRepository.AddAsync(orderStatus);

                return new CreateOrderStatusCommandResponse
                {
                    OrderStatusId = orderStatus.Id,
                    Message = "Sipariş durumu başarıyla oluşturuldu"
                };
            }
        }
    }
}
