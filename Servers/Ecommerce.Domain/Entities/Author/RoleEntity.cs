using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Author;

public class RoleEntity : FullAuditedEntity<Guid>
{
    public string Name { get; set; }

}