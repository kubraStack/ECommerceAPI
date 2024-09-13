using Application.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
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
                var userIdClaim = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                if (userIdClaim == 0)
                {
                    throw new Exception("Böyle bir kullanıcı bulunamadı.");
                }

                var user = _customerRepository.GetAsync(u => u.Id == userIdClaim);
                GetByIdCustomerSelfQueryResponse result = _mapper.Map<GetByIdCustomerSelfQueryResponse>(user);
                return result;
            }
        }
    }
}
