using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("AppUsers");

            //Set element in table.
            builder.Property(x => x.FirstName).HasMaxLength(150).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(150).IsRequired();
          

        }
    }
}
