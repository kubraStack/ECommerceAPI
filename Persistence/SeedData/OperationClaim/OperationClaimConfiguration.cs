using Core.Entitites;
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
                   Name = "Admin",
                   CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id =2,
                    Name = "Customer",
                    CreatedDate = DateTime.Now,
                }
            );

            builder.HasData(
                new Domain.Entities.OperationClaim
                {
                    Id = 3,
                    Name = "Guest",
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
                    UserId = 99,  // Kullanıcı Id (Users tablosundaki Id)
                    OperationClaimId = 1,  // Rol Id (AdminRole)
                    CreatedDate = DateTime.Now
                }
            );

            builder.HasData(
               new Domain.Entities.UserOperationClaim
               {
                   Id = 2,
                   UserId = 1,  // Kullanıcı Id (Users tablosundaki Id)
                   OperationClaimId =2,  // Rol Id (Customer Role)
                   CreatedDate = DateTime.Now
               }
            );
            
         
           
            builder.HasData(
                new Domain.Entities.UserOperationClaim
                {
                    Id=3,
                    UserId=3,
                    OperationClaimId=3,
                    CreatedDate= DateTime.Now
                }
            );

        }
    }
}
