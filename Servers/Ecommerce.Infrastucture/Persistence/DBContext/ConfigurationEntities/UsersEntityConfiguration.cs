using Ecommerce.Domain.Entities.Author;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities;

public class UsersEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasKey(u => u.Id);

        builder.Property(u => u.DisplayName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Decriptions)
            .HasMaxLength(500);

        builder.Property(u => u.Image)
            .HasMaxLength(255);

        builder.Property(u => u.Address)
            .HasMaxLength(255);

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(u => u.Email)
            .IsUnique();

        builder.Property(u => u.PasswordHash)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(u => u.PhoneNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasOne(u => u.Role)
             .WithMany()
             .HasForeignKey(u => u.RoleId)
             .IsRequired()
             .OnDelete(DeleteBehavior.Restrict);
    }
}