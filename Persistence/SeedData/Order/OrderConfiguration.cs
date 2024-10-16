﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Persistence.SeedData.Order
{
    public class OrderConfiguration : IEntityTypeConfiguration<Domain.Entities.Order>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Order> builder)
        {
            //Order Seed Data
            builder.HasData(
                new Domain.Entities.Order
                {
                    Id = 1,
                    CustomerId = 1,
                    GuestInfo =  null ,
                    TotalAmount = 1,
                    OrderStatusId = 1,
                    PaymentId = 1
                }
            );

            builder.HasData(
                new Domain.Entities.Order
                {
                    Id = 2,
                    CustomerId = 2,
                    GuestInfo = null,
                    TotalAmount = 2,
                    OrderStatusId = 2,
                    PaymentId = 2
                }
            );
        }
    }
    public class OrderDetailConfiguration : IEntityTypeConfiguration<Domain.Entities.OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            //OrderDatil Seed Data
            builder.HasData(
                new OrderDetail
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 100
                }
            );
            builder.HasData(
               new OrderDetail
               {
                   Id =     2,
                   OrderId = 2,
                   ProductId = 2,
                   Quantity = 2,
                   Price = 200
               }
           );
        }
    }
}
