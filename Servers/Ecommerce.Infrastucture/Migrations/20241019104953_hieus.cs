using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class hieus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("155d73de-35d2-4e8d-bc3f-7891fffc46ce"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("1da8a26d-2662-434d-92c4-ab9ac10ad117"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("3670d2b6-5573-4380-9beb-8645716d1d33"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("5c422f52-d9d0-4307-a09d-70b37413bf7a"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("69c307a2-89fc-4a81-b8b0-34e59024dccc"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("8e479cc9-31a2-4fa5-a588-1dd55f66a927"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("a28f6483-3a82-4f24-b315-127e49794a8a"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("a342cd47-7d0b-4f14-a778-0c695b2ff529"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("f4b403a1-9ed7-40fa-9148-7b6e84d3fa13"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("57e98e77-4298-4028-9a3d-e54a118a9ed7"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("880db8b7-b2ef-46e2-8aca-e48d5477f729"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("ca9aa08a-1b2d-41f6-97e8-ee0f3d6ccc18"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("3d3bd16c-b27f-4399-a499-0654438609bb"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("8843bcc1-2ff3-4ff6-a495-8c542a047ddb"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("b1c1c9aa-af8d-4360-a4b4-b648487f0ab0"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("2b2e50a0-6fb2-40b7-b660-315b300d48bd"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("9fb06243-06ab-4e61-ac4d-0a78a6545347"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("c1c2358d-e669-45b0-ab49-b5558978f4c2"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("6d07a84f-da5e-4813-88a7-440c930ff9f2"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("8c5f8a8b-746a-44b2-b8c6-81a6fea6c812"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("e11efab9-5554-4818-8b3a-a3153f65f442"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "Id",
                keyValue: new Guid("ef0d9c58-46a6-405b-a58a-87786ca89e5d"));

            migrationBuilder.DeleteData(
                table: "MATERIALS",
                keyColumn: "Id",
                keyValue: new Guid("08ca7bcf-addc-461f-b407-3de3ae138b87"));

            migrationBuilder.DeleteData(
                table: "MATERIALS",
                keyColumn: "Id",
                keyValue: new Guid("b17bf4cc-a5f8-43c7-bcd1-d383dc421df2"));

            migrationBuilder.DeleteData(
                table: "MODELTYPE",
                keyColumn: "Id",
                keyValue: new Guid("a5ce9ec3-2757-48ac-ba1e-269584dd276e"));

            migrationBuilder.DeleteData(
                table: "SOLETYPE",
                keyColumn: "Id",
                keyValue: new Guid("0720f4f0-304b-40c4-9d5e-c02bca032794"));

            migrationBuilder.DeleteData(
                table: "STYLES",
                keyColumn: "Id",
                keyValue: new Guid("fec9b1ab-f7e5-423f-8932-caa81b19cf7c"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ORDERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 19, 17, 49, 53, 428, DateTimeKind.Local).AddTicks(6372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 17, 17, 0, 53, 1, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.InsertData(
                table: "BRANDS",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("3d0ebb56-28fb-4f23-92fb-4d81ee6e4ae8"), "Puma", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ddac203-0728-4d73-8a26-a74093ee6b25"), "Nike", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American multinational corporation that designs, develops, and sells athletic footwear, apparel, and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("725fa419-67f8-44b9-91bc-0209592ae1ee"), "Adidas", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "German multinational corporation that designs and manufactures shoes, clothing and accessories.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CATEGORY",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name" },
                values: new object[] { new Guid("8c2db157-acfe-4efc-965f-a5bc657eca54"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athletic and casual sneakers", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneakers" });

            migrationBuilder.InsertData(
                table: "COLOR",
                columns: new[] { "Id", "Color", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsDeleted", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("36144f8a-e44e-4b85-b48c-e1192d1148ba"), "Black", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c51c2ea-571d-4600-8551-738eccf5bb56"), "White", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba777883-24c9-460c-ad56-e321f2168067"), "Red", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MATERIALS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "MaterialType", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("81237747-a31f-491e-88d2-d1b533e46639"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight, breathable synthetic material for athletic shoes.", false, "Synthetic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d5da7c1-0259-405b-acd5-ef90e730c2bf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality, durable leather material for premium footwear.", false, "Leather", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "MODELTYPE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModelType", "ModifiedBy", "ModifiedTime" },
                values: new object[] { new Guid("b26935cf-5459-41b6-8a22-9440763d5ac2"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sneakers that sit below the ankle, offering flexibility and versatility.", false, "Low-top", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "SIZE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsDeleted", "ModifiedBy", "ModifiedTime", "Size" },
                values: new object[,]
                {
                    { new Guid("1c5fb290-a24b-4ae0-bcb5-830a5ac6e579"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 8 / EU 41" },
                    { new Guid("3b7f57d5-7262-4ae4-8cbd-d498fda0a004"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 10 / EU 43" },
                    { new Guid("3ce50011-d5f7-4f7f-b702-cd9e01d0a386"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "US 9 / EU 42" }
                });

            migrationBuilder.InsertData(
                table: "SOLETYPE",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime", "SoleType" },
                values: new object[] { new Guid("08571190-dd95-4987-a485-fd9d86762c02"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A thin, level sole providing close contact with the ground.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flat" });

            migrationBuilder.InsertData(
                table: "STYLES",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Detail", "IsDeleted", "ModifiedBy", "ModifiedTime", "Style" },
                values: new object[] { new Guid("a0b405a3-41e4-4de9-9d9a-b82d22ebc6de"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Performance-oriented sneakers designed for sports and physical activities.", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Athletic" });

            migrationBuilder.InsertData(
                table: "PRODUCTS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "IdBrand", "IdCategory", "IdGender", "IdMaterial", "IdModel", "IdSoleType", "IdStyle", "IsDeleted", "ModifiedBy", "ModifiedTime", "Name", "Price", "ReleaseDate", "SKU" },
                values: new object[,]
                {
                    { new Guid("297b7860-03e7-4a9e-8e9f-8fe630972dea"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Adidas sneaker with shell toe.", new Guid("725fa419-67f8-44b9-91bc-0209592ae1ee"), new Guid("8c2db157-acfe-4efc-965f-a5bc657eca54"), new Guid("d6dc2d30-ee68-4ff2-b424-dc418d0ed104"), new Guid("9d5da7c1-0259-405b-acd5-ef90e730c2bf"), new Guid("b26935cf-5459-41b6-8a22-9440763d5ac2"), new Guid("08571190-dd95-4987-a485-fd9d86762c02"), new Guid("a0b405a3-41e4-4de9-9d9a-b82d22ebc6de"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superstar", 80.00m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS-001" },
                    { new Guid("425dfc70-2b0b-437b-82ef-4654558277dc"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iconic Nike sneaker with excellent cushioning.", new Guid("3ddac203-0728-4d73-8a26-a74093ee6b25"), new Guid("8c2db157-acfe-4efc-965f-a5bc657eca54"), new Guid("4e97f0e2-94e2-4829-8d4f-7220c7272605"), new Guid("81237747-a31f-491e-88d2-d1b533e46639"), new Guid("b26935cf-5459-41b6-8a22-9440763d5ac2"), new Guid("08571190-dd95-4987-a485-fd9d86762c02"), new Guid("a0b405a3-41e4-4de9-9d9a-b82d22ebc6de"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Max 90", 120.00m, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AM90-001" },
                    { new Guid("cdbdc976-f106-4fde-b700-51bf0278c2e9"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timeless Puma sneaker with suede upper.", new Guid("3d0ebb56-28fb-4f23-92fb-4d81ee6e4ae8"), new Guid("8c2db157-acfe-4efc-965f-a5bc657eca54"), new Guid("7b7d1210-8c76-4f58-aaeb-99076d4644de"), new Guid("9d5da7c1-0259-405b-acd5-ef90e730c2bf"), new Guid("b26935cf-5459-41b6-8a22-9440763d5ac2"), new Guid("08571190-dd95-4987-a485-fd9d86762c02"), new Guid("a0b405a3-41e4-4de9-9d9a-b82d22ebc6de"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suede Classic", 65.00m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SC-001" }
                });

            migrationBuilder.InsertData(
                table: "VARIANTS",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IdColor", "IdProduct", "IdSize", "IsDeleted", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1aab51cc-5f94-4e66-81ce-a88046ef15dd"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba777883-24c9-460c-ad56-e321f2168067"), new Guid("cdbdc976-f106-4fde-b700-51bf0278c2e9"), new Guid("3b7f57d5-7262-4ae4-8cbd-d498fda0a004"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("2487b4d6-96a9-419b-acbd-f626a181ebed"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba777883-24c9-460c-ad56-e321f2168067"), new Guid("297b7860-03e7-4a9e-8e9f-8fe630972dea"), new Guid("3b7f57d5-7262-4ae4-8cbd-d498fda0a004"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("28896ee9-1473-44ae-ab8c-bb907d654849"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c51c2ea-571d-4600-8551-738eccf5bb56"), new Guid("425dfc70-2b0b-437b-82ef-4654558277dc"), new Guid("1c5fb290-a24b-4ae0-bcb5-830a5ac6e579"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("43a59ef2-599d-498a-8830-0ec9c8378967"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c51c2ea-571d-4600-8551-738eccf5bb56"), new Guid("cdbdc976-f106-4fde-b700-51bf0278c2e9"), new Guid("1c5fb290-a24b-4ae0-bcb5-830a5ac6e579"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("6fa29be8-e38e-4bc7-841f-2a345e70f764"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ba777883-24c9-460c-ad56-e321f2168067"), new Guid("425dfc70-2b0b-437b-82ef-4654558277dc"), new Guid("3b7f57d5-7262-4ae4-8cbd-d498fda0a004"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("8800b876-ca03-4289-850c-e3302a83fe2c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36144f8a-e44e-4b85-b48c-e1192d1148ba"), new Guid("cdbdc976-f106-4fde-b700-51bf0278c2e9"), new Guid("3ce50011-d5f7-4f7f-b702-cd9e01d0a386"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("8ea055de-950d-4eba-82cd-e8709a3c63b3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36144f8a-e44e-4b85-b48c-e1192d1148ba"), new Guid("425dfc70-2b0b-437b-82ef-4654558277dc"), new Guid("3ce50011-d5f7-4f7f-b702-cd9e01d0a386"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("dc77eca8-4aab-43a8-a2c5-7b6cc219296f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36144f8a-e44e-4b85-b48c-e1192d1148ba"), new Guid("297b7860-03e7-4a9e-8e9f-8fe630972dea"), new Guid("3ce50011-d5f7-4f7f-b702-cd9e01d0a386"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { new Guid("e92abbbd-8ba8-4b7e-9697-2184cf2f88db"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6c51c2ea-571d-4600-8551-738eccf5bb56"), new Guid("297b7860-03e7-4a9e-8e9f-8fe630972dea"), new Guid("1c5fb290-a24b-4ae0-bcb5-830a5ac6e579"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("1aab51cc-5f94-4e66-81ce-a88046ef15dd"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("2487b4d6-96a9-419b-acbd-f626a181ebed"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("28896ee9-1473-44ae-ab8c-bb907d654849"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("43a59ef2-599d-498a-8830-0ec9c8378967"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("6fa29be8-e38e-4bc7-841f-2a345e70f764"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("8800b876-ca03-4289-850c-e3302a83fe2c"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("8ea055de-950d-4eba-82cd-e8709a3c63b3"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("dc77eca8-4aab-43a8-a2c5-7b6cc219296f"));

            migrationBuilder.DeleteData(
                table: "VARIANTS",
                keyColumn: "Id",
                keyValue: new Guid("e92abbbd-8ba8-4b7e-9697-2184cf2f88db"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("36144f8a-e44e-4b85-b48c-e1192d1148ba"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("6c51c2ea-571d-4600-8551-738eccf5bb56"));

            migrationBuilder.DeleteData(
                table: "COLOR",
                keyColumn: "Id",
                keyValue: new Guid("ba777883-24c9-460c-ad56-e321f2168067"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("297b7860-03e7-4a9e-8e9f-8fe630972dea"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("425dfc70-2b0b-437b-82ef-4654558277dc"));

            migrationBuilder.DeleteData(
                table: "PRODUCTS",
                keyColumn: "Id",
                keyValue: new Guid("cdbdc976-f106-4fde-b700-51bf0278c2e9"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("1c5fb290-a24b-4ae0-bcb5-830a5ac6e579"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("3b7f57d5-7262-4ae4-8cbd-d498fda0a004"));

            migrationBuilder.DeleteData(
                table: "SIZE",
                keyColumn: "Id",
                keyValue: new Guid("3ce50011-d5f7-4f7f-b702-cd9e01d0a386"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("3d0ebb56-28fb-4f23-92fb-4d81ee6e4ae8"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("3ddac203-0728-4d73-8a26-a74093ee6b25"));

            migrationBuilder.DeleteData(
                table: "BRANDS",
                keyColumn: "Id",
                keyValue: new Guid("725fa419-67f8-44b9-91bc-0209592ae1ee"));

            migrationBuilder.DeleteData(
                table: "CATEGORY",
                keyColumn: "Id",
                keyValue: new Guid("8c2db157-acfe-4efc-965f-a5bc657eca54"));

            migrationBuilder.DeleteData(
                table: "MATERIALS",
                keyColumn: "Id",
                keyValue: new Guid("81237747-a31f-491e-88d2-d1b533e46639"));

            migrationBuilder.DeleteData(
                table: "MATERIALS",
                keyColumn: "Id",
                keyValue: new Guid("9d5da7c1-0259-405b-acd5-ef90e730c2bf"));

            migrationBuilder.DeleteData(
                table: "MODELTYPE",
                keyColumn: "Id",
                keyValue: new Guid("b26935cf-5459-41b6-8a22-9440763d5ac2"));

            migrationBuilder.DeleteData(
                table: "SOLETYPE",
                keyColumn: "Id",
                keyValue: new Guid("08571190-dd95-4987-a485-fd9d86762c02"));

            migrationBuilder.DeleteData(
                table: "STYLES",
                keyColumn: "Id",
                keyValue: new Guid("a0b405a3-41e4-4de9-9d9a-b82d22ebc6de"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ORDERS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 10, 17, 17, 0, 53, 1, DateTimeKind.Local).AddTicks(5403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 10, 19, 17, 49, 53, 428, DateTimeKind.Local).AddTicks(6372));

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
        }
    }
}
