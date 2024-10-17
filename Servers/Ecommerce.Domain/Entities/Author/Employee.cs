using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Enum;
using Ecommerce.Shared.Domains.Implements;

namespace Ecommerce.Domain.Entities.Author;

public class Employee : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Số Bảo hiểm xã hội của nhân viên
    /// </summary>
    public string SocialSecurityNumber { get; set; }

    /// <summary>
    /// Họ và tên đầy đủ của nhân viên
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Ngày sinh của nhân viên
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Giới tính của nhân viên
    /// </summary>
    public Gender Gender { get; set; }

    /// <summary>
    /// Quê quán của nhân viên
    /// </summary>
    public string PlaceOfOrigin { get; set; }

    /// <summary>
    /// Địa chỉ thường trú của nhân viên
    /// </summary>
    public string ResidenceAddress { get; set; }

    /// <summary>
    /// Đặc điểm nổi bật của nhân viên
    /// </summary>
    public string DistinctiveFeatures { get; set; }

    /// <summary>
    /// Ngày cấp chứng minh nhân dân của nhân viên
    /// </summary>
    public DateTime IssueDate { get; set; }

    /// <summary>
    /// Ảnh đại diện của nhân viên
    /// </summary>
    public string Avatar { get; set; }

    /// <summary>
    /// Quốc tịch của nhân viên
    /// </summary>
    public string Nationality { get; set; }

    /// <summary>
    /// Mật khẩu đã được mã hóa của nhân viên
    /// </summary>
    public string PasswordHash { get; set; }

    /// <summary>
    /// Số điện thoại của nhân viên
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Địa chỉ email của nhân viên
    /// </summary>
    public string Email { get; set; }
    public Guid IdRole { get; set; }

    //Navigation
    public virtual RoleEntity Role { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
