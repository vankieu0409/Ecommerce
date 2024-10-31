using Ecommerce.Domain.Entities.Products;

namespace Ecommerce.Client.Services.PrdService
{
    public interface IPrdService
    {
        Task<List<Products>> GetAllProducts();
        Task<Products> AddProduct(Products product);
        Task<Products> GetProduct(Guid id);
        Task<Products> UpdateProduct(Guid id, Products product);
        Task<bool> DeleteProduct(Guid id);
    }
}
