using System.Collections.Generic;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class RoleEntity : EntityBase<Guid>
{
    public string Name { get; set; }
    public bool IsDeleted { get; set; } = false;

    // Navigation property
    public ICollection<UserEntity> Users { get; set; }

    public RoleEntity()
    {
        Users = new HashSet<UserEntity>();
    }
}