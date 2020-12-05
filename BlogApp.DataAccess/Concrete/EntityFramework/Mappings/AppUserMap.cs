using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(p => p.UserId);
            builder.Property(p => p.Firstname).HasMaxLength(50);
            builder.Property(p => p.Firstname).IsRequired();
            builder.Property(p => p.Lastname).HasMaxLength(50);
            builder.Property(p => p.Lastname).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(50);
            builder.Property(p => p.Password).IsRequired();

            builder.HasMany(p => p.Blogs).WithOne(p => p.AppUser).HasForeignKey(prop => prop.AppUserId);


        }
    }
}
