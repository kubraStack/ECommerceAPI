using Domain.Entities;
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
                   Name = "AdminRole",
                   CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 2,
                    Name = "CustomerRole",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 3,
                    Name = "GuestRole",
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<Domain.Entities.UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.UserOperationClaim> builder)
        {
            builder.HasData(
                new Domain.Entities.UserOperationClaim
                {
                    Id = 1,
                    UserId = 1,  // Kullanıcı Id (Users tablosundaki Id)
                    OperationClaimId = 1,  // Rol Id (AdminRole)
                    CreatedDate = DateTime.Now
                }
            );

            builder.HasData(
               new Domain.Entities.UserOperationClaim
               {
                   Id = 2,
                   UserId = 2,  // Kullanıcı Id (Users tablosundaki Id)
                   OperationClaimId = 2,  // Rol Id (Customer Role)
                   CreatedDate = DateTime.Now
               }
            );

        }
    }
}
