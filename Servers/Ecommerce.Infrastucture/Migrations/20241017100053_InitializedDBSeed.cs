using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitializedDBSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BRANDS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANDS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "COLOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COLOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MATERIALS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MATERIALS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MODELTYPE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODELTYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "REFRESH_TOKENS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReasonRevoked = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REFRESH_TOKENS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIZE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIZE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SOLETYPE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoleType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOLETYPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STYLES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STYLES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMERS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAddress = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CUSTOMERS_ROLES_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ROLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialSecurityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    PlaceOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenceAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistinctiveFeatures = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EMPLOYEE_ROLES_IdRole",
                        column: x => x.IdRole,
                        principalTable: "ROLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdBrand = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdModel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGender = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStyle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSoleType = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_BRANDS_IdBrand",
                        column: x => x.IdBrand,
                        principalTable: "BRANDS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_CATEGORY_IdCategory",
                        column: x => x.IdCategory,
                        principalTable: "CATEGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_MATERIALS_IdMaterial",
                        column: x => x.IdMaterial,
                        principalTable: "MATERIALS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_MODELTYPE_IdModel",
                        column: x => x.IdModel,
                        principalTable: "MODELTYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_SOLETYPE_IdSoleType",
                        column: x => x.IdSoleType,
                        principalTable: "SOLETYPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_STYLES_IdStyle",
                        column: x => x.IdStyle,
                        principalTable: "STYLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ADDRESS_CUSTOMER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDRESS_CUSTOMER", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ADDRESS_CUSTOMER_CUSTOMERS_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CUSTOMERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Payments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Refund = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 17, 17, 0, 53, 1, DateTimeKind.Local).AddTicks(5403)),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDERS_CUSTOMERS_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CUSTOMERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDERS_EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VARIANTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VARIANTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VARIANTS_COLOR_IdColor",
                        column: x => x.IdColor,
                        principalTable: "COLOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VARIANTS_PRODUCTS_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "PRODUCTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VARIANTS_SIZE_IdSize",
                        column: x => x.IdSize,
                        principalTable: "SIZE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IMAGES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVariant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IMAGES_VARIANTS_IdVariant",
                        column: x => x.IdVariant,
                        principalTable: "VARIANTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_ITEMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_ITEMS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_ORDERS_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ORDERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_ORDERS_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "ORDERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDER_ITEMS_VARIANTS_OrderId",
                        column: x => x.OrderId,
                        principalTable: "VARIANTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BRANDS",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("6d07a84f-da5e-4813-88a7-440c930ff9f2"), "Nike", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American multinational corporation that designs, develops, and sells athletic footwear, apparel, and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c5f8a8b-746a-44b2-b8c6-81a6fea6c812"), "Puma", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e11efab9-5554-4818-8b3a-a3153f65f442"), "Adidas", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "German multinational corporation that designs and manufactures shoes, clothing and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CATEGORY",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name" },
                values: new object[] { new Guid("ef0d9c58-46a6-405b-a58a-87786ca89e5d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athletic and casual sneakers", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneakers" });

            migrationBuilder.InsertData(
                table: "COLOR",
                columns: new[] { "Id", "Color", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("57e98e77-4298-4028-9a3d-e54a118a9ed7"), "White", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("880db8b7-b2ef-46e2-8aca-e48d5477f729"), "Red", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca9aa08a-1b2d-41f6-97e8-ee0f3d6ccc18"), "Black", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MATERIALS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "MaterialType", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("08ca7bcf-addc-461f-b407-3de3ae138b87"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight, breathable synthetic material for athletic shoes.", false, "Synthetic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b17bf4cc-a5f8-43c7-bcd1-d383dc421df2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality, durable leather material for premium footwear.", false, "Leather", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MODELTYPE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModelType", "ModifiedBy", "ModifiedTime" },
                values: new object[] { new Guid("a5ce9ec3-2757-48ac-ba1e-269584dd276e"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneakers that sit below the ankle, offering flexibility and versatility.", false, "Low-top", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "SIZE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsDeleted", "ModifiedBy", "ModifiedTime", "Size" },
                values: new object[,]
                {
                    { new Guid("2b2e50a0-6fb2-40b7-b660-315b300d48bd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 9 / EU 42" },
                    { new Guid("9fb06243-06ab-4e61-ac4d-0a78a6545347"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 10 / EU 43" },
                    { new Guid("c1c2358d-e669-45b0-ab49-b5558978f4c2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 8 / EU 41" }
                });

            migrationBuilder.InsertData(
                table: "SOLETYPE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime", "SoleType" },
                values: new object[] { new Guid("0720f4f0-304b-40c4-9d5e-c02bca032794"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thin, level sole providing close contact with the ground.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flat" });

            migrationBuilder.InsertData(
                table: "STYLES",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime", "Style" },
                values: new object[] { new Guid("fec9b1ab-f7e5-423f-8932-caa81b19cf7c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Performance-oriented sneakers designed for sports and physical activities.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athletic" });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "IdBrand", "IdCategory", "IdGender", "IdMaterial", "IdModel", "IdSoleType", "IdStyle", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name", "Price", "ReleaseDate", "SKU" },
                values: new object[,]
                {
                    { new Guid("3d3bd16c-b27f-4399-a499-0654438609bb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timeless Puma sneaker with suede upper.", new Guid("8c5f8a8b-746a-44b2-b8c6-81a6fea6c812"), new Guid("ef0d9c58-46a6-405b-a58a-87786ca89e5d"), new Guid("df91e3d9-a113-4145-ba39-6787a6a98218"), new Guid("b17bf4cc-a5f8-43c7-bcd1-d383dc421df2"), new Guid("a5ce9ec3-2757-48ac-ba1e-269584dd276e"), new Guid("0720f4f0-304b-40c4-9d5e-c02bca032794"), new Guid("fec9b1ab-f7e5-423f-8932-caa81b19cf7c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suede Classic", 65.00m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SC-001" },
                    { new Guid("8843bcc1-2ff3-4ff6-a495-8c542a047ddb"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Adidas sneaker with shell toe.", new Guid("e11efab9-5554-4818-8b3a-a3153f65f442"), new Guid("ef0d9c58-46a6-405b-a58a-87786ca89e5d"), new Guid("5eefb6fb-56b9-4f68-92f2-f325b8304d57"), new Guid("b17bf4cc-a5f8-43c7-bcd1-d383dc421df2"), new Guid("a5ce9ec3-2757-48ac-ba1e-269584dd276e"), new Guid("0720f4f0-304b-40c4-9d5e-c02bca032794"), new Guid("fec9b1ab-f7e5-423f-8932-caa81b19cf7c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superstar", 80.00m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS-001" },
                    { new Guid("b1c1c9aa-af8d-4360-a4b4-b648487f0ab0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iconic Nike sneaker with excellent cushioning.", new Guid("6d07a84f-da5e-4813-88a7-440c930ff9f2"), new Guid("ef0d9c58-46a6-405b-a58a-87786ca89e5d"), new Guid("43009fc4-9d8c-4d02-91fb-129c45b09680"), new Guid("08ca7bcf-addc-461f-b407-3de3ae138b87"), new Guid("a5ce9ec3-2757-48ac-ba1e-269584dd276e"), new Guid("0720f4f0-304b-40c4-9d5e-c02bca032794"), new Guid("fec9b1ab-f7e5-423f-8932-caa81b19cf7c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Max 90", 120.00m, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AM90-001" }
                });

            migrationBuilder.InsertData(
                table: "VARIANTS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IdColor", "IdProduct", "IdSize", "IsDeleted", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("155d73de-35d2-4e8d-bc3f-7891fffc46ce"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880db8b7-b2ef-46e2-8aca-e48d5477f729"), new Guid("8843bcc1-2ff3-4ff6-a495-8c542a047ddb"), new Guid("9fb06243-06ab-4e61-ac4d-0a78a6545347"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("1da8a26d-2662-434d-92c4-ab9ac10ad117"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca9aa08a-1b2d-41f6-97e8-ee0f3d6ccc18"), new Guid("3d3bd16c-b27f-4399-a499-0654438609bb"), new Guid("2b2e50a0-6fb2-40b7-b660-315b300d48bd"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("3670d2b6-5573-4380-9beb-8645716d1d33"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57e98e77-4298-4028-9a3d-e54a118a9ed7"), new Guid("b1c1c9aa-af8d-4360-a4b4-b648487f0ab0"), new Guid("c1c2358d-e669-45b0-ab49-b5558978f4c2"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("5c422f52-d9d0-4307-a09d-70b37413bf7a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880db8b7-b2ef-46e2-8aca-e48d5477f729"), new Guid("b1c1c9aa-af8d-4360-a4b4-b648487f0ab0"), new Guid("9fb06243-06ab-4e61-ac4d-0a78a6545347"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("69c307a2-89fc-4a81-b8b0-34e59024dccc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca9aa08a-1b2d-41f6-97e8-ee0f3d6ccc18"), new Guid("b1c1c9aa-af8d-4360-a4b4-b648487f0ab0"), new Guid("2b2e50a0-6fb2-40b7-b660-315b300d48bd"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("8e479cc9-31a2-4fa5-a588-1dd55f66a927"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ca9aa08a-1b2d-41f6-97e8-ee0f3d6ccc18"), new Guid("8843bcc1-2ff3-4ff6-a495-8c542a047ddb"), new Guid("2b2e50a0-6fb2-40b7-b660-315b300d48bd"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("a28f6483-3a82-4f24-b315-127e49794a8a"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880db8b7-b2ef-46e2-8aca-e48d5477f729"), new Guid("3d3bd16c-b27f-4399-a499-0654438609bb"), new Guid("9fb06243-06ab-4e61-ac4d-0a78a6545347"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("a342cd47-7d0b-4f14-a778-0c695b2ff529"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57e98e77-4298-4028-9a3d-e54a118a9ed7"), new Guid("8843bcc1-2ff3-4ff6-a495-8c542a047ddb"), new Guid("c1c2358d-e669-45b0-ab49-b5558978f4c2"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("f4b403a1-9ed7-40fa-9148-7b6e84d3fa13"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57e98e77-4298-4028-9a3d-e54a118a9ed7"), new Guid("3d3bd16c-b27f-4399-a499-0654438609bb"), new Guid("c1c2358d-e669-45b0-ab49-b5558978f4c2"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESS_CUSTOMER_CustomerId",
                table: "ADDRESS_CUSTOMER",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESS_CUSTOMER_Id",
                table: "ADDRESS_CUSTOMER",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BRANDS_BrandName_Id",
                table: "BRANDS",
                columns: new[] { "BrandName", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORY_Name_Id",
                table: "CATEGORY",
                columns: new[] { "Name", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_COLOR_Color_Id",
                table: "COLOR",
                columns: new[] { "Color", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMERS_IdRole_FullName_Id",
                table: "CUSTOMERS",
                columns: new[] { "IdRole", "FullName", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMERS_RoleId",
                table: "CUSTOMERS",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_IdRole",
                table: "EMPLOYEE",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGES_Id",
                table: "IMAGES",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGES_IdVariant",
                table: "IMAGES",
                column: "IdVariant");

            migrationBuilder.CreateIndex(
                name: "IX_MATERIALS_MaterialType_Id",
                table: "MATERIALS",
                columns: new[] { "MaterialType", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_MODELTYPE_ModelType_Id",
                table: "MODELTYPE",
                columns: new[] { "ModelType", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_OrderId_VariantId",
                table: "ORDER_ITEMS",
                columns: new[] { "OrderId", "VariantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_ITEMS_OrderId1",
                table: "ORDER_ITEMS",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_CustomerId",
                table: "ORDERS",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_EmployeeId",
                table: "ORDERS",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdBrand",
                table: "PRODUCTS",
                column: "IdBrand");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdCategory",
                table: "PRODUCTS",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdMaterial",
                table: "PRODUCTS",
                column: "IdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdModel",
                table: "PRODUCTS",
                column: "IdModel");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdSoleType",
                table: "PRODUCTS",
                column: "IdSoleType");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_IdStyle",
                table: "PRODUCTS",
                column: "IdStyle");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_Name_Id",
                table: "PRODUCTS",
                columns: new[] { "Name", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_Name",
                table: "ROLES",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SIZE_Size_Id",
                table: "SIZE",
                columns: new[] { "Size", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_SOLETYPE_SoleType_Id",
                table: "SOLETYPE",
                columns: new[] { "SoleType", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_STYLES_Style_Id",
                table: "STYLES",
                columns: new[] { "Style", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_IdColor",
                table: "VARIANTS",
                column: "IdColor");

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_IdProduct_Id",
                table: "VARIANTS",
                columns: new[] { "IdProduct", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_IdSize",
                table: "VARIANTS",
                column: "IdSize");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADDRESS_CUSTOMER");

            migrationBuilder.DropTable(
                name: "IMAGES");

            migrationBuilder.DropTable(
                name: "ORDER_ITEMS");

            migrationBuilder.DropTable(
                name: "REFRESH_TOKENS");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "VARIANTS");

            migrationBuilder.DropTable(
                name: "CUSTOMERS");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "COLOR");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "BRANDS");

            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "MATERIALS");

            migrationBuilder.DropTable(
                name: "MODELTYPE");

            migrationBuilder.DropTable(
                name: "SOLETYPE");

            migrationBuilder.DropTable(
                name: "STYLES");
        }
    }
}
