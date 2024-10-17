namespace Ecommerce.Shared.Domains.Interfaces;

public interface IEntity<TKey> : IEntity
{
    TKey Id { get; }
}