using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_DotNetCore.DAL.Migrations
{
    public partial class EditProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 388, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 22, 17, 58, 390, DateTimeKind.Local).AddTicks(795));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImages");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 745, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 9, 5, 20, 54, 28, 748, DateTimeKind.Local).AddTicks(5775));
        }
    }
}
