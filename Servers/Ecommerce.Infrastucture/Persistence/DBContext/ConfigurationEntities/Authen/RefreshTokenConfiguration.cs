using Ecommerce.Domain.Entities.Author;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Authen;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("REFRESH_TOKENS");

        builder.HasKey(rt => rt.Id);

        builder.Property(rt => rt.Token)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(rt => rt.Expires)
            .IsRequired();

        builder.Property(rt => rt.Created)
            .IsRequired();

        builder.Property(rt => rt.CreatedByIp)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(rt => rt.Revoked);

        builder.Property(rt => rt.RevokedByIp)
            .HasMaxLength(50);

        builder.Property(rt => rt.ReplacedByToken)
            .HasMaxLength(255);

        builder.Property(rt => rt.ReasonRevoked)
            .HasMaxLength(500);
    }
}