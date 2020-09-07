using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("AppRoles");

            //Set element in table.
            builder.Property(x => x.Description).HasMaxLength(300).IsRequired();



        }
    }
}