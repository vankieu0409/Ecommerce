using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Enum;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.DBContext.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Seed Categories
        var categories = new[]
        {
            new Category
            {
                Id = Guid.NewGuid(),
                Name = "Sneakers",
                Description = "Athletic and casual sneakers",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Category>().HasData(categories);

        // Seed Brands
        var brands = new[]
        {
            new Brand
            {
                Id = Guid.NewGuid(),
                BrandName = "Nike",
                Detail = "American multinational corporation that designs, develops, and sells athletic footwear, apparel, and accessories.",
                IsDeleted = false
            },
            new Brand
            {
                Id = Guid.NewGuid(),
                BrandName = "Adidas",
                Detail = "German multinational corporation that designs and manufactures shoes, clothing and accessories.",
                IsDeleted = false
            },
            new Brand
            {
                Id = Guid.NewGuid(),
                BrandName = "Puma",
                Detail = "German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories.",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Brand>().HasData(brands);

        // Seed Materials
        var materials = new[]
        {
            new Materials
            {
                Id = Guid.NewGuid(),
                MaterialType = "Leather",
                Detail = "High-quality, durable leather material for premium footwear.",
                IsDeleted = false
            },
            new Materials
            {
                Id = Guid.NewGuid(),
                MaterialType = "Synthetic",
                Detail = "Lightweight, breathable synthetic material for athletic shoes.",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Materials>().HasData(materials);

        // Seed ModelTypes
        var modelTypes = new[]
        {
            new ModelTypes
            {
                Id = Guid.NewGuid(),
                ModelType = "Low-top",
                Detail = "Sneakers that sit below the ankle, offering flexibility and versatility.",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<ModelTypes>().HasData(modelTypes);

        // Seed Styles
        var styles = new[]
        {
            new Styles
            {
                Id = Guid.NewGuid(),
                Style = "Athletic",
                Detail = "Performance-oriented sneakers designed for sports and physical activities.",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Styles>().HasData(styles);

        // Seed SoleTypes
        var soleTypes = new[]
        {
            new SoleTypes
            {
                Id = Guid.NewGuid(),
                SoleType = "Flat",
                Detail = "A thin, level sole providing close contact with the ground.",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<SoleTypes>().HasData(soleTypes);

        // Seed Sizes
        var sizes = new[]
        {
            new Sizes
            {
                Id = Guid.NewGuid(),
                Size = "US 8 / EU 41",
                IsDeleted = false
            },
            new Sizes
            {
                Id = Guid.NewGuid(),
                Size = "US 9 / EU 42",
                IsDeleted = false
            },
            new Sizes
            {
                Id = Guid.NewGuid(),
                Size = "US 10 / EU 43",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Sizes>().HasData(sizes);

        // Seed Colors
        var colors = new[]
        {
            new Colors
            {
                Id = Guid.NewGuid(),
                Color = "White",
                IsDeleted = false
            },
            new Colors
            {
                Id = Guid.NewGuid(),
                Color = "Black",
                IsDeleted = false
            },
            new Colors
            {
                Id = Guid.NewGuid(),
                Color = "Red",
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Colors>().HasData(colors);

        // Seed Products
        var products = new[]
        {
            new Products
            {
                Id = Guid.NewGuid(),
                Name = "Air Max 90",
                Description = "Iconic Nike sneaker with excellent cushioning.",
                IdCategory = categories.First().Id,
                IdBrand = brands.First(b => b.BrandName == "Nike").Id,
                IdModel = modelTypes.First().Id,
                IdMaterial = materials.First(m => m.MaterialType == "Synthetic").Id,
                IdGender = Guid.NewGuid(), // Replace with actual Gender ID
                IdStyle = styles.First().Id,
                IdSoleType = soleTypes.First().Id,
                ReleaseDate = new DateTime(2023, 1, 1),
                SKU = "AM90-001",
                Price = 120.00m,
                IsDeleted = false
            },
            new Products
            {
                Id = Guid.NewGuid(),
                Name = "Superstar",
                Description = "Classic Adidas sneaker with shell toe.",
                IdCategory = categories.First().Id,
                IdBrand = brands.First(b => b.BrandName == "Adidas").Id,
                IdModel = modelTypes.First().Id,
                IdMaterial = materials.First(m => m.MaterialType == "Leather").Id,
                IdGender = Guid.NewGuid(), // Replace with actual Gender ID
                IdStyle = styles.First().Id,
                IdSoleType = soleTypes.First().Id,
                ReleaseDate = new DateTime(2023, 2, 1),
                SKU = "SS-001",
                Price = 80.00m,
                IsDeleted = false
            },
            new Products
            {
                Id = Guid.NewGuid(),
                Name = "Suede Classic",
                Description = "Timeless Puma sneaker with suede upper.",
                IdCategory = categories.First().Id,
                IdBrand = brands.First(b => b.BrandName == "Puma").Id,
                IdModel = modelTypes.First().Id,
                IdMaterial = materials.First(m => m.MaterialType == "Leather").Id,
                IdGender = Guid.NewGuid(), // Replace with actual Gender ID
                IdStyle = styles.First().Id,
                IdSoleType = soleTypes.First().Id,
                ReleaseDate = new DateTime(2023, 3, 1),
                SKU = "SC-001",
                Price = 65.00m,
                IsDeleted = false
            }
        };
        modelBuilder.Entity<Products>().HasData(products);

        // Seed Variants
        var variants = new List<Variants>();
        foreach (var product in products)
        {
            variants.AddRange(new[]
            {
                new Variants
                {
                    Id = Guid.NewGuid(),
                    IdProduct = product.Id,
                    IdColor = colors[0].Id, // White
                    IdSize = sizes[0].Id, // US 8 / EU 41
                    Quantity = 100,
                    IsDeleted = false
                },
                new Variants
                {
                    Id = Guid.NewGuid(),
                    IdProduct = product.Id,
                    IdColor = colors[1].Id, // Black
                    IdSize = sizes[1].Id, // US 9 / EU 42
                    Quantity = 100,
                    IsDeleted = false
                },
                new Variants
                {
                    Id = Guid.NewGuid(),
                    IdProduct = product.Id,
                    IdColor = colors[2].Id, // Red
                    IdSize = sizes[2].Id, // US 10 / EU 43
                    Quantity = 100,
                    IsDeleted = false
                }
            });
        }
        modelBuilder.Entity<Variants>().HasData(variants);
    }
}
