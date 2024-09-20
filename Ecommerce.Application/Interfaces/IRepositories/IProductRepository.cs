using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Application.Interfaces.IRepositories;

public interface IProductRepository : IRepositoryBase<Products, long>
{
    Task<IEnumerable<Products>> GetProductsAsync();
    Task<Products> GetProductAsync(long id);
    Task<Products> GetProductByNoAsync(string productNo);
    Task CreateProductAsync(Products product);
    Task UpdateProductAsync(Products product);
    Task DeleteProductAsync(long id);
}