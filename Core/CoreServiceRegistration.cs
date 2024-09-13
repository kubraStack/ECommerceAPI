using Core.Application.Pipelines.Authorization;
using Core.Utilities.JWT;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, TokenOptions tokenOptions) 
        { 
            services.AddScoped<ITokenHelper, JWTHelper>(_ => new JWTHelper(tokenOptions));
            return services;
        }
    }
}
