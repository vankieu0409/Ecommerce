using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class RoleEntity : EntityAuditBase<Guid>
{
    public string Name { get; set; }

}