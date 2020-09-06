using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("Carts");
            //Set Primary Key.
            builder.HasKey(x => x.CartId);
            //Set ForeignKey
            // RelationShip 1-n with Orders.
            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Carts).HasForeignKey(x => x.UserId);
            //Set element in table.
            builder.Property(x => x.CartId).UseIdentityColumn();

        }
    }
}
