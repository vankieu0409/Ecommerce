namespace Ecommerce.Shared.Domains.Interfaces;

public interface IUserTracking
{
    string CreatedBy { get; set; }
    string LastModifiedBy { get; set; }
}