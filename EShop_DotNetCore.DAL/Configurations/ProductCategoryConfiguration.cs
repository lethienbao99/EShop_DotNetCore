using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("ProductCategories");
            //Set ForeignKey.
            builder.HasKey(t => new { t.ProductId, t.CategoryId });

            builder.HasOne(pt => pt.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pt => pt.ProductId);

            builder.HasOne(pt => pt.Category)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pt => pt.CategoryId);
        }
    }
}
