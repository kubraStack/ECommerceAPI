using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.Category
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Entities.Category>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Category> builder)
        {
            builder.HasData(
                new Domain.Entities.Category
                {
                    Id = 1,
                    Name = "Kitchen Products",
                    Description = "Tasarım Kupa, Tabak ve Çanaklar.."
                }    
                
            );
            builder.HasData(
               new Domain.Entities.Category
               {
                   Id = 2,
                   Name = "Home Decor",
                   Description = "Tasarım Ev Ürünleri"
               }

            );
            builder.HasData(
                new Domain.Entities.Category
                {
                    Id=3,
                    Name="OutDoor Decor",
                    Description="Bahçe ve Dış Tasarım Ürümleri "
                }
            );
        }
    }
}
