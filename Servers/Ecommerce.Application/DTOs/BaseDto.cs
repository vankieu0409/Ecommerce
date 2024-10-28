namespace Ecommerce.Application.DTOs;

public abstract class BaseDto
{
    public Guid Id { get; set; } // ID duy nhất cho đối tượng
    public DateTime CreatedDate { get; set; } // Ngày tạo đối tượng
    public DateTime UpdatedDate { get; set; } // Ngày cập nhật đối tượng
    public bool IsDeleted { get; set; }
}