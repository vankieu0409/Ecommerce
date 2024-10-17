namespace Ecommerce.Shared.Domains.Interfaces.Audited;

public interface IAuditedEntity :
ICreationAuditedEntity,
IModificationAuditedEntity,
IDeletionAuditedEntity,
IEntity
{

}