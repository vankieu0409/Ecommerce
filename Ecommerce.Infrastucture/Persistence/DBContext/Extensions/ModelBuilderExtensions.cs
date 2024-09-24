using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.DBContext.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Products>().HasData(
            new Products()
            {
                Id = Guid.Parse("EDD913C8-8C39-451A-8AA9-88F1EF207970"),
                Name = "Giày Adidaphat",
                Description = null
            },
            new Products()
            {
                Id = Guid.Parse("0BF03CB9-0324-4D2F-A94C-3693B4BFFCA8"),
                Name = "Giày Adidalat",
                Description = null

            }
        );

        modelBuilder.Entity<Variants>().HasData(
            new Variants()
            {
                Id = Guid.Parse("6d408fa5-fb74-417c-b6a9-ecaeb44adf9c"),
                IdProduct = Guid.Parse("EDD913C8-8C39-451A-8AA9-88F1EF207970"),
                Price = 100000,
                Quantity = 28
            },
            new Variants()
            {
                Id = Guid.Parse("fc1d2608-4915-4a98-90e3-1991d642a294"),
                IdProduct = Guid.Parse("6d408fa5-fb74-417c-b6a9-ecaeb44adf9c"),
                Price = 900000,
                Quantity = 2
            },
            new Variants()
            {
                Id = Guid.Parse("a46649b4-54f3-4c69-9daf-bec14cfaa9e9"),
                IdProduct = Guid.Parse("0BF03CB9-0324-4D2F-A94C-3693B4BFFCA8"),
                Price = 900000,
                Quantity = 2
            }
        );
    }
}