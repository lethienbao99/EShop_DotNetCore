﻿// <auto-generated />
using System;
using EShop_DotNetCore.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EShop_DotNetCore.DAL.Migrations
{
    [DbContext(typeof(EShopDBContext))]
    [Migration("20200906063409_AddImage")]
    partial class AddImage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "Homepage of the EShop"
                        },
                        new
                        {
                            Key = "Keyword",
                            Value = "Keyword of the EShop"
                        },
                        new
                        {
                            Key = "Description",
                            Value = "Description of the EShop"
                        });
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            IsShowOnHome = true,
                            Name = "Tech",
                            Slug = "tech",
                            SortOrder = 1,
                            Status = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            IsShowOnHome = true,
                            Name = "Smartphone",
                            Slug = "smartphone",
                            SortOrder = 2,
                            Status = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            IsShowOnHome = true,
                            Name = "Laptop",
                            Slug = "laptop",
                            SortOrder = 3,
                            Status = 1
                        });
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipNumberPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 867, DateTimeKind.Local).AddTicks(8273),
                            Description = "",
                            Detail = "best TV",
                            Name = "TV",
                            Price = 5500m,
                            Slug = "best-tv",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 2,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2269),
                            Description = "",
                            Detail = "best mircowave",
                            Name = "Microwave",
                            Price = 5600m,
                            Slug = "best-mircowave",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 3,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2377),
                            Description = "",
                            Detail = "best the android smartphone from samsung",
                            Name = "Samsung Note 20 Ultra",
                            Price = 5500m,
                            Slug = "samsung-note-20-ultra",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 4,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2381),
                            Description = "",
                            Detail = "best the android smartphone from OnePlus",
                            Name = "OnePlus 8 Pro 5G",
                            Price = 5500m,
                            Slug = "oneplus-8pro-5g",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 5,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2388),
                            Description = "",
                            Detail = "best the android smartphone from OnePlus",
                            Name = "OnePlus 8 Pro 5G",
                            Price = 5500m,
                            Slug = "oneplus-8pro-5g",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 6,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2390),
                            Description = "",
                            Detail = "best the android smartphone from OnePlus",
                            Name = "OnePlus 8 Pro 5G",
                            Price = 5500m,
                            Slug = "oneplus-8pro-5g",
                            Stock = 0,
                            ViewCount = 0
                        },
                        new
                        {
                            ProductId = 7,
                            DateCreated = new DateTime(2020, 9, 6, 13, 34, 8, 869, DateTimeKind.Local).AddTicks(2392),
                            Description = "",
                            Detail = "best the android smartphone from OnePlus",
                            Name = "OnePlus 8 Pro 5G",
                            Price = 5500m,
                            Slug = "oneplus-8pro-5g",
                            Stock = 0,
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Promotion", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApplyForAll")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ExternalTransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("user_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Cart", b =>
                {
                    b.HasOne("EShop_DotNetCore.DAL.Models.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.Image", b =>
                {
                    b.HasOne("EShop_DotNetCore.DAL.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.OrderDetail", b =>
                {
                    b.HasOne("EShop_DotNetCore.DAL.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EShop_DotNetCore.DAL.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EShop_DotNetCore.DAL.Models.ProductCategory", b =>
                {
                    b.HasOne("EShop_DotNetCore.DAL.Models.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EShop_DotNetCore.DAL.Models.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}