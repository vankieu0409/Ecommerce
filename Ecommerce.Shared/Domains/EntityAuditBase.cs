using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Shared.Domains;

public abstract class EntityAuditBase<T> : EntityBase<T>, IEntityAuditBase<T>
{
    public DateTime CreatedTime { get; set; }
    public Guid CreatedBy { get; set; }

    public DateTime? LastModifiedTime { get; set; }
    public Guid ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
}