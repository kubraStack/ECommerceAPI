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

namespace Application.Features.User.Queries.GetByIdSelf
{
    public class GetByIdUserSelfQuery : IRequest<GetByIdUserSelfQueryResponse>
    {
        public class GetByIdUserSelfQueryHandler : IRequestHandler<GetByIdUserSelfQuery, GetByIdUserSelfQueryResponse>
        {
            private readonly IUserRepository _userRepository;
            private readonly IMapper _mapper;
            private readonly IHttpContextAccessor _httpContextAccessor;

            public GetByIdUserSelfQueryHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            {
                _userRepository = userRepository;
                _mapper = mapper;
                _httpContextAccessor = httpContextAccessor;
            }

            public async Task<GetByIdUserSelfQueryResponse> Handle(GetByIdUserSelfQuery request, CancellationToken cancellationToken)
            {
                var userIdClaim = int.Parse(_httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier).Value);
                if (userIdClaim == 0)
                {
                    throw new Exception("Bu kullanıcının bilgilerine ulaşamazsınız");
                }
                var user = await _userRepository.GetAsync(u => u.Id == userIdClaim);
                GetByIdUserSelfQueryResponse result = _mapper.Map<GetByIdUserSelfQueryResponse>(user);
                return result;
            }
        }
    }
}
