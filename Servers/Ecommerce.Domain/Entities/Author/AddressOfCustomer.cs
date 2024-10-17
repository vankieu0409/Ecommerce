using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Author;

public class AddressOfCustomer : FullAuditedEntity<Guid>
{
    public string Address { get; set; } //Địa chỉ cụ thể
    /// <summary>
    /// Tên đường hoặc phố. Bắt buộc và có độ dài tối đa là 100 ký tự.
    /// </summary>
    public string StreetAddress { get; set; }

    /// <summary>
    /// Phường hoặc xã.
    /// Thường được sử dụng trong các khu vực đô thị.
    /// </summary>
    public string Ward { get; set; }  // Phường/Xã

    /// <summary>
    /// Quận hoặc huyện.
    /// </summary>
    public string District { get; set; }  // Quận/Huyện

    /// <summary>
    /// Thành phố hoặc tỉnh.
    /// </summary>
    public string City { get; set; }  // Thành phố/Tỉnh

    //navigation
    public Guid CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}