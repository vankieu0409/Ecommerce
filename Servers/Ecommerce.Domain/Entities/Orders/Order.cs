using Ecommerce.Domain.Entities.Author;
using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Orders
{
    public class Order : EntityBase<Guid>
    {
        public Guid EmployeeId { get; set; }
        public Guid CustomerId { get; set; }
        public decimal Payments { get; set; }
        public decimal Refund { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public string Voucher { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
