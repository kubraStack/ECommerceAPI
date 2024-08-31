using Core.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.SeedData.BaseUserConfiguration
{
    public class BaseUserConfiguration : IEntityTypeConfiguration<BaseUser>
    {
        public void Configure(EntityTypeBuilder<BaseUser> builder)
        {
            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("FirstName");
            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnName("LastName");
        }
    }
}
