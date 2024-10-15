using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Application.Interfaces.IRepositories;

public interface IProductRepository : IRepositoryBase<Products, Guid>
{
    Task<IEnumerable<Products>> GetProductsAsync();
    Task<Products> GetProductByIdAsync(Guid id);
    public Task<Products> GetProductByNameAsync(string name);
    Task CreateProductAsync(Products product);
    Task UpdateProductAsync(Products product);
    Task DeleteProductAsync(Guid id);
    Task<IEnumerable<Products>> GetAllProductsAsync();
}