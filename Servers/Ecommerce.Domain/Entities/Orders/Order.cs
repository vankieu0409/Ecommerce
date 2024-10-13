using Ecommerce.Shared.Domains;

using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Entities.Author;

namespace Ecommerce.Domain.Entities.Orders
{
    public class Order : EntityBase<Guid>
    {
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public decimal Deposit { get; set; }
        public decimal Balance { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public string Voucher { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
