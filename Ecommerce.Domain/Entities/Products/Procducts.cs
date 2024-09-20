using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Products
{
    public class Products : EntityBase<long>
    {
        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<Variants> Variants { get; set; } = new List<Variants>();
    }
}
