using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("Orders");

            //Set PrimaryKey.
            builder.HasKey(x => x.OrderId);

            //Set element in table.
            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);

        }
    }
}
