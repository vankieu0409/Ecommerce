using Ecommerce.Shared.Domains;

namespace Ecommerce.Domain.Entities.Author;

public class Employee : EntityAuditBase<Guid>
{
    public string SocialSecurityNumber { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string PlaceOfOrigin { get; set; }
    public string ResidenceAddress { get; set; }
    public string DistinctiveFeatures { get; set; }
    public DateTime IssueDate { get; set; }
    public string Avatar { get; set; }
    public string Nationality { get; set; }
    public string PasswordHash { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}