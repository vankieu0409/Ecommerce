using Ecommerce.Shared.Domains;

using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Orders
{
    public class OrderEntity : EntityBase<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public List<OrderItemEntity> OrderItems { get; set; }
    }
}
