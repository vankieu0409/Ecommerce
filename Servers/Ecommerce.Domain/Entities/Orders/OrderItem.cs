using System.ComponentModel.DataAnnotations.Schema;

using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Orders
{
    public class OrderItem : EntityBase<Guid>
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public string ProductName { get; set; }
        public string VariantDetails { get; set; } // e.g., "Color: Red, Size: XL"

        // Navigation properties
        public Order Order { get; set; }
        public Products.Products Product { get; set; }
        public Variants Variant { get; set; }
    }
}
