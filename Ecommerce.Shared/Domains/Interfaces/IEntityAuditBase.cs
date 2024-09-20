namespace Ecommerce.Shared.Domains.Interfaces;

public interface IEntityAuditBase<T> : IEntityBase<T>, IAuditable
{
    bool IsDeleted { get; set; }
}