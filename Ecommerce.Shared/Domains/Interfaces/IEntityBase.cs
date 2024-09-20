namespace Ecommerce.Shared.Domains.Interfaces;

public interface IEntityBase<T>
{
    T Id { get; set; }
}