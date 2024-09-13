using Application.Abstracts;
using Infrastructure.Services.EmailService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
           services.AddScoped<IMailService, MailService>();
            return services;
        }
    }
}
