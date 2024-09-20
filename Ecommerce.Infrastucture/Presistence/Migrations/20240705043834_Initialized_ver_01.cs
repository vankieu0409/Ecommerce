using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initialized_ver_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OPTIONS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OPTION_VALUES",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOption = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTION_VALUES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OPTION_VALUES_OPTIONS_IdOption",
                        column: x => x.IdOption,
                        principalTable: "OPTIONS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VARIANTS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<long>(type: "bigint", nullable: false),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VARIANTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VARIANTS_PRODUCTS_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "PRODUCTS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VARIANT_DETAILS",
                columns: table => new
                {
                    IdVariant = table.Column<long>(type: "bigint", nullable: false),
                    IdOption = table.Column<long>(type: "bigint", nullable: false),
                    IdValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VARIANT_DETAILS", x => new { x.IdVariant, x.IdOption, x.IdValue });
                    table.ForeignKey(
                        name: "FK_VARIANT_DETAILS_OPTIONS_IdOption",
                        column: x => x.IdOption,
                        principalTable: "OPTIONS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VARIANT_DETAILS_OPTION_VALUES_IdValue",
                        column: x => x.IdValue,
                        principalTable: "OPTION_VALUES",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VARIANT_DETAILS_VARIANTS_IdVariant",
                        column: x => x.IdVariant,
                        principalTable: "VARIANTS",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "OPTIONS",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Size" },
                    { 2L, "Brand" },
                    { 3L, "Color" }
                });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Id", "Description", "ProductName" },
                values: new object[,]
                {
                    { 1L, null, "Áo Adidaphat" },
                    { 2L, null, "Quần Adidalat" }
                });

            migrationBuilder.InsertData(
                table: "OPTION_VALUES",
                columns: new[] { "Id", "IdOption", "Value" },
                values: new object[,]
                {
                    { 1L, 1L, "M" },
                    { 2L, 1L, "L" },
                    { 3L, 1L, "XL" },
                    { 4L, 1L, "XXL" },
                    { 5L, 1L, "S" },
                    { 6L, 3L, "Red" },
                    { 7L, 1L, "Green" },
                    { 8L, 1L, "Blue" }
                });

            migrationBuilder.InsertData(
                table: "VARIANTS",
                columns: new[] { "Id", "IdProduct", "Images", "Price", "Quantity", "VariantName" },
                values: new object[,]
                {
                    { 1L, 1L, null, 100000m, 28, "NK_XXL_RED" },
                    { 2L, 1L, null, 900000m, 2, "NK_XL_RED" },
                    { 3L, 1L, null, 900000m, 2, "NK_L_GRE" }
                });

            migrationBuilder.InsertData(
                table: "VARIANT_DETAILS",
                columns: new[] { "IdOption", "IdValue", "IdVariant" },
                values: new object[,]
                {
                    { 1L, 4L, 1L },
                    { 3L, 6L, 1L },
                    { 1L, 3L, 2L },
                    { 3L, 6L, 2L },
                    { 1L, 2L, 3L },
                    { 3L, 7L, 3L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OPTION_VALUES_IdOption_Id_Value",
                table: "OPTION_VALUES",
                columns: new[] { "IdOption", "Id", "Value" });

            migrationBuilder.CreateIndex(
                name: "IX_OPTIONS_Name_Id",
                table: "OPTIONS",
                columns: new[] { "Name", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_ProductName_Id",
                table: "PRODUCTS",
                columns: new[] { "ProductName", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_VARIANT_DETAILS_IdOption",
                table: "VARIANT_DETAILS",
                column: "IdOption");

            migrationBuilder.CreateIndex(
                name: "IX_VARIANT_DETAILS_IdValue",
                table: "VARIANT_DETAILS",
                column: "IdValue");

            migrationBuilder.CreateIndex(
                name: "IX_VARIANT_DETAILS_IdVariant_IdOption_IdValue",
                table: "VARIANT_DETAILS",
                columns: new[] { "IdVariant", "IdOption", "IdValue" });

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_IdProduct_Id",
                table: "VARIANTS",
                columns: new[] { "IdProduct", "Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VARIANT_DETAILS");

            migrationBuilder.DropTable(
                name: "OPTION_VALUES");

            migrationBuilder.DropTable(
                name: "VARIANTS");

            migrationBuilder.DropTable(
                name: "OPTIONS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");
        }
    }
}
