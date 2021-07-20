using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VnExpress.Data.Entities;

namespace VnExpress.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.ShortContent).IsRequired();
            builder.Property(p => p.MainContent).IsRequired();
            builder.Property(p => p.Author).IsRequired();
            builder.Property(p => p.DateCreated).IsRequired();
            builder.Property(p => p.Images).IsRequired();
            builder.HasOne(p => p.Category).WithMany(p => p.Posts).HasForeignKey(p => p.CategoryId);
            
        }
    }
}
