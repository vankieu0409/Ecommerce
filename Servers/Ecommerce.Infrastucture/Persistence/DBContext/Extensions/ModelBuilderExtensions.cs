using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Enum;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.DBContext.Extensions;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        var roles = Enum.GetValues(typeof(Role))
            .Cast<Role>()
            .Select(r => new RoleEntity()
            {
                Id = Guid.NewGuid(),
                Name = r.ToString(),
                IsDeleted = false
            })
            .ToArray();

        modelBuilder.Entity<RoleEntity>().HasData(roles);



    }
}