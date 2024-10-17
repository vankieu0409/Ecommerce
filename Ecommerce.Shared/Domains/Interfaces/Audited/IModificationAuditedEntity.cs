namespace Ecommerce.Shared.Domains.Interfaces.Audited;

public interface IModificationAuditedEntity
{

    DateTime ModifiedTime { get; }

    Guid? ModifiedBy { get; }
}