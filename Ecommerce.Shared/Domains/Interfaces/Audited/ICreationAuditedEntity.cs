namespace Ecommerce.Shared.Domains.Interfaces.Audited;

public interface ICreationAuditedEntity
{
    DateTime CreatedTime { get; }
    Guid? CreatedBy { get; }
}