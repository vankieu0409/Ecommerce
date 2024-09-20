using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Infrastructure.Presistence.DBContext;
using Ecommerce.Shared.Common.Repositories;
using Ecommerce.Shared.Domains.Interfaces;

namespace Ecommerce.Infrastructure.Presistence.Repositories;

public class ProductRepository : RepositoryBase<Products, long, ApplicationDbContext>, IProductRepository
{
    public ProductRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
    {
    }

    public Task<IEnumerable<Products>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Products> GetProductAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Products> GetProductByNoAsync(string productNo)
    {
        throw new NotImplementedException();
    }

    public Task CreateProductAsync(Products product)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProductAsync(Products product)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductAsync(long id)
    {
        throw new NotImplementedException();
    }
}