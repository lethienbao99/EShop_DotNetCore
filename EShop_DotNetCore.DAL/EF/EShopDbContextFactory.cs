using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace EShop_DotNetCore.DAL.EF
{
    //dsd
    class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDBContext>
    {
        public EShopDBContext CreateDbContext(string[] args)
        {
            //Read ConnectString in Json File.
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectString = configuration.GetConnectionString("EShopDB_DNC");

            var optionsBuilder = new DbContextOptionsBuilder<EShopDBContext>();
            optionsBuilder.UseSqlServer(connectString);

            return new EShopDBContext(optionsBuilder.Options);
        }
    }
}
