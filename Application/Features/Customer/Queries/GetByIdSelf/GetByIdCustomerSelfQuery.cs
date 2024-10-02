using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Customer.Queries.GetByIdSelf
{
    public class GetByIdCustomerSelfQuery : IRequest<GetByIdCustomerSelfQueryResponse>
    {
        public class GetByIdCustomerSelfQueryHandler : IRequestHandler<GetByIdCustomerSelfQuery, GetByIdCustomerSelfQueryResponse>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IMapper _mapper;

            public GetByIdCustomerSelfQueryHandler(ICustomerRepository customerRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
            {
                _customerRepository = customerRepository;
                _httpContextAccessor = httpContextAccessor;
                _mapper = mapper;
            }

            public async Task<GetByIdCustomerSelfQueryResponse> Handle(GetByIdCustomerSelfQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out var userId) || userId == 0)
                {
                    throw new Exception("Böyle bir kullanıcı bulunamadı.");
                }

                // User tablosunu dahil et
                var customer = await _customerRepository.GetAsync(
                       c => c.UserId == userId,
                       include: c => c
                        .Include(u => u.User)
                        .Include(c =>c.Orders)
                        .ThenInclude(o => o.OrderDetail)
                );
                

                if (customer == null)
                {
                    throw new Exception("Müşteri Bulunamadı");
                }

                GetByIdCustomerSelfQueryResponse result = _mapper.Map<GetByIdCustomerSelfQueryResponse>(customer);
                return result;
            }
        }
    }
}