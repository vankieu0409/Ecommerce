using System.Collections.ObjectModel;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class RoleEntity : EntityBase<Guid>
{
    public string Name { get; set; }
    public Collection<UserEntity> UserEntities { get; set; }
}