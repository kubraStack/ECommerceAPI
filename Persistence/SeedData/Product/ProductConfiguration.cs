using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Product
{
    public class ProductConfiguration : IEntityTypeConfiguration<Domain.Entities.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product> builder)
        {
            builder.HasData(
                new Domain.Entities.Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Eyeliner",
                    Description = "Description",
                    Price = 500,
                    StockQuantity = 10,
                    ImageUrl = "https://images.pexels.com/photos/4938197/pexels-photo-4938197.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                   
                }    
                
            );
            builder.HasData(
               new Domain.Entities.Product
               {
                   Id = 2,
                   CategoryId = 2,
                   Name = "C Vitaminli Krem",
                   Description = "Description",
                   Price = 300,
                   StockQuantity = 5,
                   ImageUrl = "https://images.pexels.com/photos/9748717/pexels-photo-9748717.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",

               }

           );
        }
    }

    public class ProductReviewConfiguration : IEntityTypeConfiguration<Domain.Entities.ProductReview>
    {
        public void Configure(EntityTypeBuilder<ProductReview> builder)
        {
            builder.HasData(
                new ProductReview
                {
                    Id = 1,
                    ProductId = 1,
                    CustomerId = 1,
                    Review = "Bu eyeliner harikaa!",
                    Rating = 5,
                    ReviewDate = new DateTime(2024, 1, 5)
                }
            );
            builder.HasData(
               new ProductReview
               {
                   Id = 2,
                   ProductId = 2,
                   CustomerId = 2,
                   Review = "Bu ruj harikaa!",
                   Rating = 5,
                   ReviewDate = new DateTime(2024, 1, 5)
               }
           );
        }
    }


}
