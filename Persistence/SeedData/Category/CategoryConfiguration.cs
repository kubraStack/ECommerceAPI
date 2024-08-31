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
                    Name ="Kozmetik",
                    Description = "Kozmetik ürünleri kategorisi"
                }    
                
            );
            builder.HasData(
               new Domain.Entities.Category
               {
                   Id = 2,
                   Name = "Cilt Bakım",
                   Description = "Cilt bakım ürünleri kategorisi"
               }

           );
        }
    }
}
