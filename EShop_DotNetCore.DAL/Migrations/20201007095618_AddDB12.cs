using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_DotNetCore.DAL.Migrations
{
    public partial class AddDB12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ee976566-d4be-407b-96d4-5c69da8806a8"),
                column: "ConcurrencyStamp",
                value: "9582e951-9047-4c1a-85c9-6eb18fb28a89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25237a43-fef4-4bcc-8c52-ee8c2624d54f", "AQAAAAEAACcQAAAAEBTeuu+2EXAAOYNIpi07zvIpRPDC7mfjaYoESeGDB+0o7m3Wm+cKjKlNJNirk1uAUA==" });

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
                value: new DateTime(2020, 10, 7, 16, 56, 17, 660, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 10, 7, 16, 56, 17, 662, DateTimeKind.Local).AddTicks(5831));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
