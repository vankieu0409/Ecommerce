using Ecommerce.Domain.Entities.Author;
using Ecommerce.Domain.Entities.Orders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Persistence.DBContext.ConfigurationEntities.Authen;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("EMPLOYEE");
        builder.HasKey(u => u.Id);

        builder.HasOne(u => u.Role)
             .WithMany()
             .HasForeignKey(u => u.IdRole)
             .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany<Order>(u => u.Orders)
            .WithOne(o => o.Employee)
            .HasForeignKey(u => u.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
    }

}