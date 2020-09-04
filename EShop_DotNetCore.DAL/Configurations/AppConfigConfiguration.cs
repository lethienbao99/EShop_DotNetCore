using System;
using System.Collections.Generic;
using System.Text;
using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop_DotNetCore.DAL.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            //Fulent API.
            //*****************************

            //Set table name.
            builder.ToTable("AppConfigs");
            //Set Primary Key.
            builder.HasKey(x => x.Key);
            //Set element in table.
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
