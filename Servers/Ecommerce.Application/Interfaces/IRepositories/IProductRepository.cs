using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Common.Repositories;

namespace Ecommerce.Application.Interfaces.IRepositories;

public interface IProductRepository : IRepositoryAsync<Products>
{
    Task<Products> GetByIdAsync(Guid id);
}