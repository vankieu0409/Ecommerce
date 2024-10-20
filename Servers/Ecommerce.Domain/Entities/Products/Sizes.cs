using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Products;

public class Sizes : FullAuditedEntity<Guid>
{
    public string Size { get; set; }

    public List<Variants> Variants { get; set; }

}