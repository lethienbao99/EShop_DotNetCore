using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            //Fulent API.
            //*****************************
            //Set table name.
            builder.ToTable("Images");
            //Set Primary Key.
            builder.HasKey(x => x.ImageId);
            builder.HasOne(x => x.Product).WithMany(x => x.Images).HasForeignKey(x => x.ProductId);
            //Set element in table.
            builder.Property(x => x.IsDefault).HasDefaultValue(false);


        }

       
    }
}
