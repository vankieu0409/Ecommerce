using Ecommerce.Domain.Entities.Products;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Products;

public class StyleConfiguration : IEntityTypeConfiguration<Styles>
{

    public void Configure(EntityTypeBuilder<Styles> builder)
    {
        builder.ToTable("STYLES");
        builder.HasKey(c => c.Id);
        builder.HasIndex(c => new { c.Style, c.Id });
        builder.HasMany<Domain.Entities.Products.Products>(p => p.Products).WithOne(c => c.Style)
          .HasForeignKey(c => c.IdStyle);
        //  .OnDelete(DeleteBehavior.Cascade);
    }
}