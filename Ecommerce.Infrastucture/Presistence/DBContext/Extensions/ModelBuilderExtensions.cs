using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Presistence.DBContext.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Products>().HasData(
            new Products()
            {
                Id = 1,
                ProductName = "Áo Adidaphat",
                Description = null
            },
            new Products()
            {
                Id = 2,
                ProductName = "Quần Adidalat",
                Description = null

            }
        );

        modelBuilder.Entity<Variants>().HasData(
            new Variants()
            {
                Id = 1,
                IdProduct = 1,
                VariantName = "NK_XXL_RED",
                Price = 100000,
                Quantity = 28
            },
            new Variants()
            {
                Id = 2,
                IdProduct = 1,
                VariantName = "NK_XL_RED",
                Price = 900000,
                Quantity = 2
            },
            new Variants()
            {
                Id = 3,
                IdProduct = 1,
                VariantName = "NK_L_GRE",
                Price = 900000,
                Quantity = 2
            }
        );
        modelBuilder.Entity<Option>().HasData(
            new Option()
            {
                Id = 1,
                Name = "Size"
            },
            new Option()
            {
                Id = 2,
                Name = "Brand"
            },
            new Option()
            {
                Id = 3,
                Name = "Color"
            }
        );

        modelBuilder.Entity<OptionValues>().HasData(
            new OptionValues()
            {
                Id = 1,
                IdOption = 1,
                Value = "M"
            },
            new OptionValues()
            {
                Id = 2,
                IdOption = 1,
                Value = "L"
            },
            new OptionValues()
            {
                Id = 3,
                IdOption = 1,
                Value = "XL"
            },
            new OptionValues()
            {
                Id = 4,
                IdOption = 1,
                Value = "XXL"
            },
            new OptionValues()
            {
                Id = 5,
                IdOption = 1,
                Value = "S"
            },
            new OptionValues()
            {
                Id = 6,
                IdOption = 3,
                Value = "Red"
            },
            new OptionValues()
            {
                Id = 7,
                IdOption = 1,
                Value = "Green"
            },
            new OptionValues()
            {
                Id = 8,
                IdOption = 1,
                Value = "Blue"
            }
        );

        modelBuilder.Entity<VariantDetail>().HasData(
            new VariantDetail()
            {
                IdVariant = 1,
                IdOption = 1,
                IdValue = 4
            },
            new VariantDetail()
            {
                IdVariant = 1,
                IdOption = 3,
                IdValue = 6
            },
            new VariantDetail()
            {
                IdVariant = 2,
                IdOption = 1,
                IdValue = 3
            },
            new VariantDetail()
            {
                IdVariant = 2,
                IdOption = 3,
                IdValue = 6
            },
            new VariantDetail()
            {
                IdVariant = 3,
                IdOption = 1,
                IdValue = 2
            },
            new VariantDetail()
            {
                IdVariant = 3,
                IdOption = 3,
                IdValue = 7
            });
    }
}