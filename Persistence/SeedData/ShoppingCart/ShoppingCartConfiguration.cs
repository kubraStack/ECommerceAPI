using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.ShoppingCart
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<Domain.Entities.ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.ShoppingCart> builder)
        {
            builder.HasData(
                new Domain.Entities.ShoppingCart
                {
                    Id = 1,
                    CustomerId= 1,

                }    
                
            );
            builder.HasData(
               new Domain.Entities.ShoppingCart
               {
                   Id = 2,
                   CustomerId = 2,

               }

            );
        }
    }

    public class ShoppingCartDetailConfiguration : IEntityTypeConfiguration<Domain.Entities.ShoppingCartDetail>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartDetail> builder)
        {
            builder.HasData(
                new Domain.Entities.ShoppingCartDetail
                {
                    Id = 1,
                    ShoppingCartId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 500,
                }    
            );
            builder.HasData(
                new Domain.Entities.ShoppingCartDetail
                {
                    Id = 2,
                    ShoppingCartId = 2,
                    ProductId = 2,
                    Quantity = 2,
                    Price = 300,
                }
            );
        }
    }
}
