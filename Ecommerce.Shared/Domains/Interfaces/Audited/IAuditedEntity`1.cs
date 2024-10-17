namespace Ecommerce.Shared.Domains.Interfaces.Audited;

public interface IAuditedEntity<TKey> :
    ICreationAuditedEntity,
    IModificationAuditedEntity,
    IDeletionAuditedEntity,
    IEntity<TKey>,
    IEntity
{

}