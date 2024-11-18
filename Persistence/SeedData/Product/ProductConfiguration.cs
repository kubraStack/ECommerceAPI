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
            builder.HasData(
               new Domain.Entities.Product
               {
                   Id = 4,
                   CategoryId = 1,
                   Name = "Kupa",
                   Description = "Description",
                   Price = 350,
                   StockQuantity = 55,
                   ImageUrl = "https://websitedemos.net/ceramic-products-store-04/wp-content/uploads/sites/1413/2024/02/ceramic-cup-01-300x300.jpg"
               }
            );
            builder.HasData(
               new Domain.Entities.Product
               {
                   Id = 5,
                   CategoryId = 2,
                   Name = "Vazo",
                   Description = "Description",
                   Price = 750,
                   StockQuantity = 25,
                   ImageUrl = "https://images.pexels.com/photos/29432556/pexels-photo-29432556/free-photo-of-masada-mumlu-mavi-vazoda-mor-cicekler.jpeg"
               }
            );
            builder.HasData(
              new Domain.Entities.Product
              {
                  Id = 6,
                  CategoryId = 3,
                  Name = "Saksı",
                  Description = "Description",
                  Price = 550,
                  StockQuantity = 85,
                  ImageUrl = "https://images.pexels.com/photos/21273580/pexels-photo-21273580/free-photo-of-yapraklar-pencereler-camlar-bitkiler.jpeg"
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
            builder.HasData(
                new ProductReview
                {
                    Id = 4,
                    ProductId = 4,
                    CustomerId = 3,
                    Review = "Çok güzel bir kupa ve kullanışlı.",
                    Rating =4,
                    ReviewDate = new DateTime(2024, 2, 7)
                }
            );
            builder.HasData(
                new ProductReview
                {
                    Id = 5,
                    ProductId = 5,
                    CustomerId = 3,
                    Review = "Çok güzel bir vazo ve çok şık durdu.",
                    Rating = 5,
                    ReviewDate = new DateTime(2024, 2, 7)
                }
            );
            builder.HasData(
                new ProductReview
                {
                    Id = 6,
                    ProductId = 5,
                    CustomerId = 3,
                    Review = "Çok güzel bir saksı çiceklerimle çok uyumlu.",
                    Rating = 5,
                    ReviewDate = new DateTime(2024, 2, 7)
                }
            );
        }
    }


}
