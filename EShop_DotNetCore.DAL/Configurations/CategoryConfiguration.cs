using EShop_DotNetCore.DAL.Enums;
using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("Categories");
            //Set Primary Key.
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
