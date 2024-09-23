using Ecommerce.Shared.Domains;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Orders
{
    public class Order : EntityBase<Guid>
    {
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
