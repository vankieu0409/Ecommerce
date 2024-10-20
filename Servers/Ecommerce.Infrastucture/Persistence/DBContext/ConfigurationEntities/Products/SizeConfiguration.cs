using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class SizeConfiguration : IEntityTypeConfiguration<Sizes>
{
    public void Configure(EntityTypeBuilder<Sizes> builder)
    {
        builder.ToTable("SIZE");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.Size, c.Id });

        // Configure one-to-many relationship
        builder.HasMany(p => p.Variants)
               .WithOne(c => c.Sizes)
               .HasForeignKey(c => c.IdSize)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
