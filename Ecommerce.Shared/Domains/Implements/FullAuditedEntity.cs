using Ecommerce.Shared.Domains.Interfaces;
using Ecommerce.Shared.Domains.Interfaces.Audited;

namespace Ecommerce.Shared.Domains.Implements;

public class FullAuditedEntity :
    Entity,
    IAuditedEntity,
    ICreationAuditedEntity,
    IModificationAuditedEntity,
    IDeletionAuditedEntity,
    IEntity
{
    public DateTime CreatedTime { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime ModifiedTime { get; set; }
    public Guid? ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
    public Guid? DeletedBy { get; set; }
    public DateTime DeletedTime { get; set; }
}