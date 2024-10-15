using Ecommerce.Domain.Entities.Author;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Authen;

public class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>

{
    public void Configure(EntityTypeBuilder<RoleEntity> builder)
    {
        builder.ToTable("ROLES");

        builder.HasKey(r => r.Id);

        builder.Property(r => r.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(r => r.IsDeleted)
            .HasDefaultValue(false);

        // Tạo index duy nhất cho Name để đảm bảo tên vai trò không trùng lặp
        builder.HasIndex(r => r.Name)
            .IsUnique();
    }
}