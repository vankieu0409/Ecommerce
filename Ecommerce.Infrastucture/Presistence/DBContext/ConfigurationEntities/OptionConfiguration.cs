using Ecommerce.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Presistence.DBContext.ConfigurationEntities;

public class OptionConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.ToTable("OPTIONS");
        builder.HasKey(c => c.Id);
        builder.HasMany(c => c.VariantDetails).WithOne(c => c.IdOptionNavigation).HasForeignKey(c => c.IdOption).OnDelete(DeleteBehavior.NoAction);
        builder.HasMany(c => c.OptionsValues).WithOne(c => c.IdOptionNavigation).HasForeignKey(c => c.IdOption).OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(c => new { c.Name, c.Id });
        builder.Property(c => c.Id).IsRequired();
        builder.Property(c => c.Name).HasMaxLength(200);
    }
}