using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("Products");
            //Set Primary Key.
            builder.HasKey(x => x.ProductId);
            //Set element in table.
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.Stock).IsRequired(true).HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired(true).HasDefaultValue(0);


        }
    }
}
