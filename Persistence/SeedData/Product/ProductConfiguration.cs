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
                    Name = "Kupa",
                    Description = "Description",
                    Price = 500,
                    StockQuantity = 10,
                    ImageUrl = "https://images.pexels.com/photos/11020238/pexels-photo-11020238.jpeg",
                   
                }    
                
            );
            builder.HasData(
               new Domain.Entities.Product
               {
                   Id = 2,
                   CategoryId = 2,
                   Name = "Vazo",
                   Description = "Description",
                   Price = 300,
                   StockQuantity = 5,
                   ImageUrl = "https://images.pexels.com/photos/6805518/pexels-photo-6805518.jpeg",

               }

            );
            builder.HasData(
                new Domain.Entities.Product
                {
                    Id=3,
                    CategoryId = 3,
                    Name="Saksı",
                    Description= "Description",
                    Price= 500,
                    StockQuantity = 25,
                    ImageUrl= "https://images.pexels.com/photos/9130701/pexels-photo-9130701.jpeg"
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
                    Review = "Bu kupa harikaa! Çok kullanışlı..",
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
                   Review = "Bu vazo harikaa! Evime çok güzel bir hava getirdi.",
                   Rating = 5,
                   ReviewDate = new DateTime(2024, 1, 5)
               }
            );
            builder.HasData(
                new ProductReview
                {
                    Id=3,
                    ProductId=3,
                    CustomerId= 3,
                    Review="Çok güzel bir saksı.",
                    Rating = 5,
                    ReviewDate = new DateTime(2024,2,7)
                }    
            );
        }
    }


}
