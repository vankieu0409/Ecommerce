using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Images : FullAuditedEntity<Guid>
{
    public Guid IdVariant { get; set; }
    public string URL { get; set; }
    public string Name { get; set; }
    public Variants Variants { get; set; }

}