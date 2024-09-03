﻿using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using Persistence.Context;
using Persistence.Respositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
            //Console.WriteLine(Directory.GetCurrentDirectory());
            configurationManager.AddJsonFile("appsettings.json");



            services.AddDbContext<ECommerceDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, EfUserRepository>();
            services.AddScoped<IUserOperationClaimRepository, EfUserOperationClaimRepository>();
            services.AddScoped<IOperationClaimRepository, EfOperationClaimRepository>();
            services.AddScoped<ICustomerRepository, EfCustomerRepository>();
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IOrderRepository, EfOrderRepository>();
            services.AddScoped<IOrderDetailRepository, EfOrderDetailRepository>();
            services.AddScoped<IOrderStatusRepository, EfOrderStatusRepository>();
            services.AddScoped<IPaymentRepository, EfPaymentRepository>();
            services.AddScoped<IPaymentMethodRepository, EfPaymentMethodRepository>();
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<IProductReviewRepository, EfProductReviewRepository>();
            services.AddScoped<IShoppingCartRepository, EfShoppingCartRepository>();
            services.AddScoped<IShoppingCartDetailRepository, EfShoppingCartDetailRepository>();
            return services;
        }
    }
}
