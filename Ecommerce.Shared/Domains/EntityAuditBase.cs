using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Shared.Domains;

public abstract class EntityAuditBase<T> : EntityBase<T>, IEntityAuditBase<T>
{
    public DateTimeOffset CreatedDate { get; set; }

    public DateTimeOffset? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
}