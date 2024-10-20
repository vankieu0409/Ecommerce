using System.Collections.ObjectModel;

using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Colors : FullAuditedEntity<Guid>
{
    public string Color { get; set; }
    public Collection<Variants> Variants { get; set; }
}