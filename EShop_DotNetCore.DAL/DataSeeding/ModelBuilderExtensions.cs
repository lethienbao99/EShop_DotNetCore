using EShop_DotNetCore.DAL.Enums;
using EShop_DotNetCore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.DataSeeding
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //AppConfig
            modelBuilder.Entity<AppConfig>()
                .HasData
                (
                new AppConfig()
                {
                    Key = "HomeTitle",
                    Value = "Homepage of the EShop"
                },
                new AppConfig()
                {
                    Key = "Keyword",
                    Value = "Keyword of the EShop"
                },
                new AppConfig()
                {
                    Key = "Description",
                    Value = "Description of the EShop"
                }
                );

            //Product
            modelBuilder.Entity<Product>()
                .HasData
                (
                        new Product()
                        {
                            ProductId = 1,
                            DateCreated = DateTime.Now,
                            Price = 5500,
                            Stock = 0,
                            ViewCount = 0,
                            Description = "",
                            Name = "TV",
                            Detail = "best TV",
                            Slug = "best-tv"
                        },
                        new Product()
                        {
                            ProductId = 2,
                            DateCreated = DateTime.Now,
                            Price = 5600,
                            Stock = 0,
                            ViewCount = 0,
                            Description = "",
                            Name = "Microwave",
                            Detail = "best mircowave",
                            Slug = "best-mircowave"
                        },
                       new Product()
                       {
                           ProductId = 3,
                           DateCreated = DateTime.Now,
                           Price = 5500,
                           Stock = 0,
                           ViewCount = 0,
                           Description = "",
                           Name = "Samsung Note 20 Ultra",
                           Detail = "best the android smartphone from samsung",
                           Slug = "samsung-note-20-ultra"
                       },
                       new Product()
                       {
                           ProductId = 4,
                           DateCreated = DateTime.Now,
                           Price = 5500,
                           Stock = 0,
                           ViewCount = 0,
                           Description = "",
                           Name = "OnePlus 8 Pro 5G",
                           Detail = "best the android smartphone from OnePlus",
                           Slug = "oneplus-8pro-5g"
                       },
                      new Product()
                      {
                          ProductId = 5,
                          DateCreated = DateTime.Now,
                          Price = 5500,
                          Stock = 0,
                          ViewCount = 0,
                          Description = "",
                          Name = "OnePlus 8 Pro 5G",
                          Detail = "best the android smartphone from OnePlus",
                          Slug = "oneplus-8pro-5g"
                      },
                      new Product()
                      {
                          ProductId = 6,
                          DateCreated = DateTime.Now,
                          Price = 5500,
                          Stock = 0,
                          ViewCount = 0,
                          Description = "",
                          Name = "OnePlus 8 Pro 5G",
                          Detail = "best the android smartphone from OnePlus",
                          Slug = "oneplus-8pro-5g"
                      },
                      new Product()
                      {
                          ProductId = 7,
                          DateCreated = DateTime.Now,
                          Price = 5500,
                          Stock = 0,
                          ViewCount = 0,
                          Description = "",
                          Name = "OnePlus 8 Pro 5G",
                          Detail = "best the android smartphone from OnePlus",
                          Slug = "oneplus-8pro-5g"
                      }
                   );


            //Category
            modelBuilder.Entity<Category>()
                .HasData
                (
                new Category()
                {
                    CategoryId = 1,
                    Name = "Tech",
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                    IsShowOnHome = true,
                    Slug = "tech"
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Smartphone",
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                    IsShowOnHome = true,
                    Slug = "smartphone"
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Laptop",
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active,
                    IsShowOnHome = true,
                    Slug = "laptop"
                }
                );

            modelBuilder.Entity<ProductCategory>().HasData(
                   new ProductCategory() { ProductId = 1, CategoryId = 1 },
                   new ProductCategory() { ProductId = 2, CategoryId = 1 },
                   new ProductCategory() { ProductId = 3, CategoryId = 2 },
                   new ProductCategory() { ProductId = 4, CategoryId = 2 },
                   new ProductCategory() { ProductId = 5, CategoryId = 2 },
                   new ProductCategory() { ProductId = 6, CategoryId = 2 },
                   new ProductCategory() { ProductId = 7, CategoryId = 3 }
                   );

        }
    }
}
