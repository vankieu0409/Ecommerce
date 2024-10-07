using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class kieunv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Decriptions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEntity_RoleEntity_RoleEntityId",
                        column: x => x.RoleEntityId,
                        principalTable: "RoleEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEntity_RoleEntity_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDERS_UserEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_ITEMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariantDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_ITEMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ORDERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_PRODUCTS_ProductId",
                        column: x => x.ProductId,
                        principalTable: "PRODUCTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_VARIANTS_VariantId",
                        column: x => x.VariantId,
                        principalTable: "VARIANTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_OrderId_VariantId",
                table: "ORDER_ITEMS",
                columns: new[] { "OrderId", "VariantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_ProductId",
                table: "ORDER_ITEMS",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_VariantId",
                table: "ORDER_ITEMS",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_UserId",
                table: "ORDERS",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_Email",
                table: "UserEntity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_RoleEntityId",
                table: "UserEntity",
                column: "RoleEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_RoleId",
                table: "UserEntity",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDER_ITEMS");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "RoleEntity");
        }
    }
}
