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

namespace Application.Features.OrderStatus.Queries.GetAllOrderStatus
{
    public class GetAllOrderStatusQuery : IRequest<List<GetAllOrderStatusQueryResponse>>, ISequredRequest
    {
        public string[] RequiredRoles => ["Admin"];

        public class GetAllOrderStatusQueryHandler : IRequestHandler<GetAllOrderStatusQuery, List<GetAllOrderStatusQueryResponse>>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IOrderStatusRepository _orderStatusRepository;

            public GetAllOrderStatusQueryHandler(IHttpContextAccessor httpContextAccessor, IOrderStatusRepository orderStatusRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _orderStatusRepository = orderStatusRepository;
            }

            public async Task<List<GetAllOrderStatusQueryResponse>> Handle(GetAllOrderStatusQuery request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                if (userRole != "Admin")
                {
                    throw new Exception("Bu İşlemi Yapmaya Yetkiniz Yok.");
                }

                var orderStatuses = await _orderStatusRepository.GetListAsync();

                var response = orderStatuses.Select(status => new GetAllOrderStatusQueryResponse
                {
                    Id = status.Id,
                    Name = status.Name,
                    Description = status.Description
                }).ToList();

                return response;
            }
        }
    }
    
}
