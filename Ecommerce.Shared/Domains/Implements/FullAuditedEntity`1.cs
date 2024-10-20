using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Ecommerce.Shared.Domains.Interfaces;
using Ecommerce.Shared.Domains.Interfaces.Audited;

namespace Ecommerce.Shared.Domains.Implements;

public class FullAuditedEntity<TKey> :
    FullAuditedEntity,
    IAuditedEntity<TKey>,
    ICreationAuditedEntity,
    IModificationAuditedEntity,
    IDeletionAuditedEntity,
    IEntity<TKey>,
    IEntity
{
    [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public TKey Id { get; set; }
}