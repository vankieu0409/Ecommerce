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
                Name = "Áo Adidaphat",
                Description = null
            },
            new Products()
            {
                Id = 2,
                Name = "Quần Adidalat",
                Description = null

            }
        );

        modelBuilder.Entity<Variants>().HasData(
            new Variants()
            {
                Id = 1,
                IdProduct = 1,
                Price = 100000,
                Quantity = 28
            },
            new Variants()
            {
                Id = 2,
                IdProduct = 1,
                Price = 900000,
                Quantity = 2
            },
            new Variants()
            {
                Id = 3,
                IdProduct = 1,
                Price = 900000,
                Quantity = 2
            }
        );
    }
}