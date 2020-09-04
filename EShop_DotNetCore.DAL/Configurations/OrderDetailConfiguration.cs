using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("OrderDetails");
            //Set PrimaryKey.
            builder.HasKey(x => new { x.OrderId, x.ProductId });

            //Set ForeignKey
            // RelationShip 1-n with Orders.
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);

            // RelationShip 1-n with Products.
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);

        }
    }
}
