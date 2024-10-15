using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ORDERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 14, 16, 39, 21, 144, DateTimeKind.Local).AddTicks(1098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 14, 16, 36, 20, 918, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.InsertData(
                table: "ROLES",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "LastModifiedTime", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("4531972f-838a-4c96-aca7-130b17255dec"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), "Admin" },
                    { new Guid("7f10cb1c-b7c8-41e0-9232-7a65b30f8bcf"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), "Customer" },
                    { new Guid("8e6b60eb-606f-4a12-a816-dde1241647da"), new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), "Employee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ROLES",
                keyColumn: "Id",
                keyValue: new Guid("4531972f-838a-4c96-aca7-130b17255dec"));

            migrationBuilder.DeleteData(
                table: "ROLES",
                keyColumn: "Id",
                keyValue: new Guid("7f10cb1c-b7c8-41e0-9232-7a65b30f8bcf"));

            migrationBuilder.DeleteData(
                table: "ROLES",
                keyColumn: "Id",
                keyValue: new Guid("8e6b60eb-606f-4a12-a816-dde1241647da"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ORDERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 14, 16, 36, 20, 918, DateTimeKind.Local).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 14, 16, 39, 21, 144, DateTimeKind.Local).AddTicks(1098));
        }
    }
}
