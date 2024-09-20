using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Shared.Domains;

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
    public TKey Id { get; set; }

}