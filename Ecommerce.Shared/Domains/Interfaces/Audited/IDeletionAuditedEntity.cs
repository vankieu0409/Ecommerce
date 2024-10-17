namespace Ecommerce.Shared.Domains.Interfaces.Audited;

public interface IDeletionAuditedEntity
{
    bool IsDeleted { get; }

    Guid? DeletedBy { get; }

    DateTime DeletedTime { get; }
}