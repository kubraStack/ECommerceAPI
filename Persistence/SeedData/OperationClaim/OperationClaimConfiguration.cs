using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.OperationClaim
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<Domain.Entities.OperationClaim>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.OperationClaim> builder)
        {
            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 1,
                    Name = "Admin",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
               new Domain.Entities.OperationClaim
               {
                   Id = 2,
                   Name = "Customer",
                   CreatedDate = DateTime.Now,
               }
            );

            builder.HasData(
              new Domain.Entities.OperationClaim
              {
                  Id = 3,
                  Name = "Unknow",
                  CreatedDate = DateTime.Now,
              }
           );
        }
    }
}
