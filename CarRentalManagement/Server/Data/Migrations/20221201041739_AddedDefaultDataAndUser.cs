using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "b38fb404-c44f-47fa-971f-cff8ec4397f0", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "608bdf88-d4d7-48e3-bb4f-2c1b7b528f7e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "96a75a36-9b9f-4ac8-9d0d-659a87065e39", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEBUMhJYwGOyrJLhoa8KKqYiYiU+3WNn5x5QS2EzIAKovlrp5mip6/CEa/YpEF82PjQ==", null, false, "9ac7beb0-810f-47e0-9422-7ab522d899db", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 17, 39, 188, DateTimeKind.Local).AddTicks(1408), new DateTime(2022, 12, 1, 12, 17, 39, 189, DateTimeKind.Local).AddTicks(8819), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 17, 39, 189, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 12, 1, 12, 17, 39, 189, DateTimeKind.Local).AddTicks(9413), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(6037), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(6042), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(6044), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(6044), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2904), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2916), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2919), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2920), "XS", "System" },
                    { 3, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2965), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2966), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2968), new DateTime(2022, 12, 1, 12, 17, 39, 191, DateTimeKind.Local).AddTicks(2969), "RAV 4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
