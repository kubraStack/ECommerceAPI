using Domain.Entities;
using Core.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Hashing;

namespace Persistence.SeedData.User
{
    public class UserConfiguration : IEntityTypeConfiguration<Domain.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User> builder)
        {
            
            HashingHelper.CreatePasswordHash("123456", out byte[] passwordHash1, out byte[] passwordSalt1);

            // User Seed Data
            builder.HasData(
                new Domain.Entities.User
                {
                    Id = 1,
                    FirstName = "Alina",
                    LastName = "Jast",
                    Email = "customer1@example.com",
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    PhoneNumber = "1234567890",
                    Gender = "Famela",
                    UserType = UserType.Customer,
                    CreatedDate = DateTime.UtcNow
                }
            );

            builder.HasData(
               new Domain.Entities.User
               {
                   Id = 2,
                   FirstName = "Jonathan",
                   LastName = "Corwin",
                   Email = "customer2@example.com",
                   PasswordHash = passwordHash1,
                   PasswordSalt = passwordSalt1,
                   PhoneNumber = "1234512345",
                   Gender = "Male",
                   UserType = UserType.Customer,
                   CreatedDate = DateTime.UtcNow
               }
            );

            builder.HasData(

               new Domain.Entities.User
               {
                   Id = 3,
                   FirstName = "Ziyaretçi",
                   LastName = "Guest",
                   Email = "guest1@example.com",
                   PasswordHash = passwordHash1,
                   PasswordSalt = passwordHash1,
                   PhoneNumber = "2568947898",
                   Gender = "Male",
                   UserType = UserType.Guest,
                   CreatedDate = DateTime.UtcNow
               }

            );
            builder.HasData(
               new Domain.Entities.User
               {
                   Id = 99,
                   FirstName = "Admin",
                   LastName = "Yönetici",
                   Email = "admin1@example.com",
                   PasswordHash = passwordHash1,
                   PasswordSalt = passwordHash1,
                   PhoneNumber = "1234512345",
                   Gender = "Male",
                   UserType = UserType.Admin,
                   CreatedDate = DateTime.UtcNow
               }
            );
           
        }



    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Domain.Entities.Customer>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Customer> builder)
        {
            //Customer Seed Data

            builder.HasData(
                new Domain.Entities.Customer
                {
                    Id = 1,
                    UserId = 1,
                    ShippingAddress = "1234 Any St.",
                    BillingAddress = "1234 Any St."
                }
            );

            builder.HasData(
               new Domain.Entities.Customer
               {
                   Id = 2,
                   UserId= 2,
                   ShippingAddress = "4321 Ny St.",
                   BillingAddress = "4321 Ny St."
               }
           );
        }
    }

    
}
