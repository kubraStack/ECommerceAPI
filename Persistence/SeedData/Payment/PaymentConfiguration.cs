using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Payment
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Domain.Entities.Payment>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Payment> builder)
        {
            builder.HasData(
                
                new Domain.Entities.Payment
                {
                    Id = 1,
                    OrderId = 1,
                    Amount = 500,
                    PaymentDate = DateTime.Now,
                    PaymentId = 1,
                }
                
            );
            builder.HasData(

               new Domain.Entities.Payment
               {
                   Id = 2,
                   OrderId = 2,
                   Amount = 200,
                   PaymentDate = DateTime.Now,
                   PaymentId = 2,
               }

           );
        }
    }
}
