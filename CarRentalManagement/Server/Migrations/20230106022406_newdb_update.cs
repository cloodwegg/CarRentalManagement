using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8a73120f-40b1-4270-9be0-4225acc07112");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "cc14dba8-0abd-4465-86d8-e8a65b9b4e9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54fd0e19-9647-4814-b32b-580d97bb5b18", "AQAAAAEAACcQAAAAEPHu2iuLW/qo43wQwG0Sn33PQeeCeBHGaROGuIaUQlQRK1yLucbPJbWuJDJcq7sT/A==", "b06e2d58-7c57-4dd5-9cef-cebf828d12c9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 941, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 1, 6, 10, 24, 5, 943, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 943, DateTimeKind.Local).AddTicks(1889), new DateTime(2023, 1, 6, 10, 24, 5, 943, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(8223), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(8240), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2734), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2774), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2778), new DateTime(2023, 1, 6, 10, 24, 5, 945, DateTimeKind.Local).AddTicks(2780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "ca35e289-a86e-4ab4-9204-dfd7ee09882c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "ec86a1b6-8c85-4ce0-bcf3-69bd3035b1f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d69019a-c610-4512-b652-7d9bce06bcfe", "AQAAAAEAACcQAAAAEDAn49xnq3p/CVqnUSFOYXcUxU/lj0k2LD321fc4s57DcqoJDDIv7h2AbY4mKfxNLg==", "969e6a8c-b661-4abd-90d6-7344be28b160" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 187, DateTimeKind.Local).AddTicks(721), new DateTime(2023, 1, 6, 7, 30, 38, 188, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 188, DateTimeKind.Local).AddTicks(9305), new DateTime(2023, 1, 6, 7, 30, 38, 188, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 192, DateTimeKind.Local).AddTicks(5489), new DateTime(2023, 1, 6, 7, 30, 38, 192, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 192, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 1, 6, 7, 30, 38, 192, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(3960), new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4020), new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4026), new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4032), new DateTime(2023, 1, 6, 7, 30, 38, 191, DateTimeKind.Local).AddTicks(4035) });
        }
    }
}
