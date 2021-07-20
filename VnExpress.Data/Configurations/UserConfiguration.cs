using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VnExpress.Data.Entities;

namespace VnExpress.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.IdUser);
            builder.Property(u => u.IdUser).UseIdentityColumn();
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.ConfirmPassword).IsRequired();

        }
    }
}
