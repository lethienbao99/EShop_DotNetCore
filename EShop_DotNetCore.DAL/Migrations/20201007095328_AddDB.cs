using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_DotNetCore.DAL.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ee976566-d4be-407b-96d4-5c69da8806a8"),
                column: "ConcurrencyStamp",
                value: "37a075df-086b-4014-adc0-3b871b17fd4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a741ce5-ed63-401c-aafc-2f10a14fe82d", "AQAAAAEAACcQAAAAEN1x2s2J/1j0oUht5lw+WKbsjy+kNJyv3AopHrgDSdaC1EADMU/Qmec+IMxx0eKuEw==" });

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
                value: new DateTime(2020, 10, 7, 16, 53, 27, 255, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 53, 27, 257, DateTimeKind.Local).AddTicks(5675));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ee976566-d4be-407b-96d4-5c69da8806a8"),
                column: "ConcurrencyStamp",
                value: "1ba34de3-bfa8-4ec3-96dc-286129fcc2c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fa9028b-0305-4ebb-bd97-ce7c1d07a0c2", "AQAAAAEAACcQAAAAEG1WTFXv93aZzNxZtLZ+FLwhVNJV7uQvib7fUTHdzGD0dn9OBd8SPDIiYoeDMI/obg==" });

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
                value: new DateTime(2020, 9, 6, 21, 51, 43, 62, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 51, 43, 63, DateTimeKind.Local).AddTicks(8308));
        }
    }
}
