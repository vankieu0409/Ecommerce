using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class SoleTypeConfiguration : IEntityTypeConfiguration<SoleTypes>
{
    public void Configure(EntityTypeBuilder<SoleTypes> builder)
    {
        builder.ToTable("SOLETYPE");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.SoleType, c.Id });
        builder.HasMany<Domain.Entities.Products.Products>(p => p.Products).WithOne(c => c.SoleType)
            .HasForeignKey(c => c.IdSoleType).OnDelete(DeleteBehavior.Cascade);
    }
}