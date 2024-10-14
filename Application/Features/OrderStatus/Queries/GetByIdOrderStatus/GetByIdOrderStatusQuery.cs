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

namespace Application.Features.OrderStatus.Queries.GetByIdOrderStatus
{
    public class GetByIdOrderStatusQuery : IRequest<GetByIdOrderStatusQueryResponse>, ISequredRequest
    {
        public int Id { get; set; }

        public GetByIdOrderStatusQuery(int ıd)
        {
            Id = ıd;
        }

        public string[] RequiredRoles => ["Admin"];
        public class GetByIdOrderStatusQueryHandler : IRequestHandler<GetByIdOrderStatusQuery, GetByIdOrderStatusQueryResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderStatusRepository _orderStatusRepository;

            public GetByIdOrderStatusQueryHandler(IHttpContextAccessor httpContextAccessor, IOrderStatusRepository orderStatusRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderStatusRepository = orderStatusRepository;
            }

            public async Task<GetByIdOrderStatusQueryResponse> Handle(GetByIdOrderStatusQuery request, CancellationToken cancellationToken)
            {
                var userClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                if (userClaim != "Admin")
                {
                    throw new Exception("Bu İşlem İçin Yetkiniz Yok");
                }

                var orderStatus = await _orderStatusRepository.GetByIdAsync(request.Id);
                if (orderStatus == null)
                {
                    throw new Exception("Sipariş Durumu Bulunamadı");
                }

                return new GetByIdOrderStatusQueryResponse
                {
                    OrderStatusId = orderStatus.Id,
                    OrderName = orderStatus.Name,
                    Description = orderStatus.Description
                };
            }
        }
    }
}
