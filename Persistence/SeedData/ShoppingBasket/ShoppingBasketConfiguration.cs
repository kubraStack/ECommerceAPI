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
    public class ShoppingBasketConfiguration : IEntityTypeConfiguration<Domain.Entities.ShoppingBasket>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.ShoppingBasket> builder)
        {
            builder.HasData(
                new Domain.Entities.ShoppingBasket
                {
                    Id = 1,
                    CustomerId= 1,

                }    
                
            );
            builder.HasData(
               new Domain.Entities.ShoppingBasket
               {
                   Id = 2,
                   CustomerId = 2,

               }

            );
        }
    }

    public class ShoppingBasketDetailConfiguration : IEntityTypeConfiguration<Domain.Entities.ShoppingBasketDetail>
    {
        public void Configure(EntityTypeBuilder<ShoppingBasketDetail> builder)
        {
            builder.HasData(
                new Domain.Entities.ShoppingBasketDetail
                {
                    Id = 1,
                    ShoppingBasketId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 500,
                }    
            );
            builder.HasData(
                new Domain.Entities.ShoppingBasketDetail
                {
                    Id = 2,
                    ShoppingBasketId = 2,
                    ProductId = 2,
                    Quantity = 2,
                    Price = 300,
                }
            );
        }
    }
}
