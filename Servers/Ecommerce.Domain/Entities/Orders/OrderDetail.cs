using System.ComponentModel.DataAnnotations.Schema;

using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Orders
{
    public class OrderDetail : EntityAuditBase<Guid>
    {
        public Guid OrderId { get; set; }
        public Guid VariantId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        // Navigation properties
        public Order Order { get; set; }
        public Variants Variant { get; set; }
    }
}
