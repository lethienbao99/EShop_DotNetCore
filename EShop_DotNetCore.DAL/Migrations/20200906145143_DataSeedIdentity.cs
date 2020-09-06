using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_DotNetCore.DAL.Migrations
{
    public partial class DataSeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ee976566-d4be-407b-96d4-5c69da8806a8"), "1ba34de3-bfa8-4ec3-96dc-286129fcc2c6", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"), 0, "2fa9028b-0305-4ebb-bd97-ce7c1d07a0c2", "lethienbao3012@gmail.com", true, "Le", "Bao", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEG1WTFXv93aZzNxZtLZ+FLwhVNJV7uQvib7fUTHdzGD0dn9OBd8SPDIiYoeDMI/obg==", null, false, "", false, "admin" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"), new Guid("ee976566-d4be-407b-96d4-5c69da8806a8") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"), new Guid("ee976566-d4be-407b-96d4-5c69da8806a8") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ee976566-d4be-407b-96d4-5c69da8806a8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fd3bc079-8c61-4ff2-a5b7-278a58ec5273"));

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
                value: new DateTime(2020, 9, 6, 21, 43, 58, 22, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2020, 9, 6, 21, 43, 58, 23, DateTimeKind.Local).AddTicks(6552));
        }
    }
}
