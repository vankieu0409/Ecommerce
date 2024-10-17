using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class ColorConfiguration : IEntityTypeConfiguration<Colors>
{
    public void Configure(EntityTypeBuilder<Colors> builder)
    {
        builder.ToTable("COLOR");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.Color, c.Id });

        // Configure one-to-many relationship
        builder.HasMany(c => c.Variants)
               .WithOne(v => v.Colors)
               .HasForeignKey(v => v.IdColor)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
