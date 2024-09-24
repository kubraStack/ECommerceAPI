using Core.CrossCuttingConcerns.Exceptions.Types;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Authorization
{
    public class AuthorizationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>, ISequredRequest
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public AuthorizationBehavior(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        
        }
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                
                throw new Core.CrossCuttingConcerns.Exceptions.Types.BusinessException("Giriş Yapmadınız.");
            }

            if (request.RequiredRoles.Any())
            {
                ICollection<string>? userRoles = _contextAccessor.HttpContext.User.Claims
                    .Where(i => i.Type == ClaimTypes.Role)
                    .Select(i => i.Value)
                    .ToList();

                var matchingRole = userRoles.FirstOrDefault(i => i == "Admin" || request.RequiredRoles.Contains(i));
                bool hasNoMatchingRole = string.IsNullOrEmpty(matchingRole);

                if (hasNoMatchingRole) {
                    throw new Core.CrossCuttingConcerns.Exceptions.Types.BusinessException("Bunu yapmaya yetkiniz yok..");
                
                }
            }

            TResponse response = await next();
            return response;
        }
    }
}
