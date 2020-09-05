using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("ProductImages");
            //Set Primary Key.
            builder.HasKey(x => x.ProductImageId);
            builder.HasOne(x => x.Product).WithMany(x => x.ProductImages).HasForeignKey(x => x.ProductId);
            //Set element in table.
            builder.Property(x => x.Path).IsRequired(true);
            builder.Property(x => x.Path).HasMaxLength(200).IsRequired(false);



        }
    }
}
