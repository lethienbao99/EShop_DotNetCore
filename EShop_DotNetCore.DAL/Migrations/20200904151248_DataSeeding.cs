using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_DotNetCore.DAL.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "Homepage of the EShop" },
                    { "Keyword", "Keyword of the EShop" },
                    { "Description", "Description of the EShop" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "IsShowOnHome", "Name", "ParentId", "Slug", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, "Tech", null, "tech", 1, 1 },
                    { 2, true, "Smartphone", null, "smartphone", 2, 1 },
                    { 3, true, "Laptop", null, "laptop", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateCreated", "Description", "Detail", "Name", "Price", "Slug" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 4, 22, 12, 48, 271, DateTimeKind.Local).AddTicks(8080), "", "best TV", "TV", 5500m, "best-tv" },
                    { 2, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1511), "", "best mircowave", "Microwave", 5600m, "best-mircowave" },
                    { 3, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1603), "", "best the android smartphone from samsung", "Samsung Note 20 Ultra", 5500m, "samsung-note-20-ultra" },
                    { 4, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1608), "", "best the android smartphone from OnePlus", "OnePlus 8 Pro 5G", 5500m, "oneplus-8pro-5g" },
                    { 5, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1610), "", "best the android smartphone from OnePlus", "OnePlus 8 Pro 5G", 5500m, "oneplus-8pro-5g" },
                    { 6, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1612), "", "best the android smartphone from OnePlus", "OnePlus 8 Pro 5G", 5500m, "oneplus-8pro-5g" },
                    { 7, new DateTime(2020, 9, 4, 22, 12, 48, 273, DateTimeKind.Local).AddTicks(1614), "", "best the android smartphone from OnePlus", "OnePlus 8 Pro 5G", 5500m, "oneplus-8pro-5g" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Description");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Keyword");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);
        }
    }
}
