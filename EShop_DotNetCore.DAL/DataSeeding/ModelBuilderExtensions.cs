using EShop_DotNetCore.DAL.Enums;
using EShop_DotNetCore.DAL.Models;
using Microsoft.AspNetCore.Identity;
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


            // any guid
            var roleId = new Guid("EE976566-D4BE-407B-96D4-5C69DA8806A8");
            var adminId = new Guid("FD3BC079-8C61-4FF2-A5B7-278A58EC5273");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "lethienbao3012@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123abC!"),
                SecurityStamp = string.Empty,
                FirstName = "Le",
                LastName = "Bao",
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}