using Core.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.BaseUser
{
    public class BaseUserConfiguration : IEntityTypeConfiguration<Core.Entitites.BaseUser>
    {
        public void Configure(EntityTypeBuilder<Core.Entitites.BaseUser> builder)
        {
            builder.Property(u => u.FirstName)
                .HasColumnName("FirstName")
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(u => u.LastName)
                .HasColumnName("LastName")
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
