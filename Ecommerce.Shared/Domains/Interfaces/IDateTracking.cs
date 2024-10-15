namespace Ecommerce.Shared.Domains.Interfaces;

public interface IDateTracking
{
    DateTime CreatedTime { get; set; }
    Guid CreatedBy { get; set; }

    DateTime? LastModifiedTime { get; set; }
    Guid ModifiedBy { get; set; }
}