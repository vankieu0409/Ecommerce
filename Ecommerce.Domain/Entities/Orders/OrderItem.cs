using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Domain.Entities.Orders
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
        public Products.Products Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
