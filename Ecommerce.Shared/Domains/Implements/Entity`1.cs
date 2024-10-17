using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Shared.Domains.Implements;

public abstract class Entity<TKey> : Entity, IEntity<TKey>, IEntity
{
    [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public virtual TKey Id { get; set; }
}