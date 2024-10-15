using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Shared.Common.Repositories;
using Ecommerce.Shared.Domains.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence.Repositories;

public class ProductRepository : RepositoryBase<Products, Guid, ApplicationDbContext>, IProductRepository
{

    public ProductRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
    {
    }

    public async Task<IEnumerable<Products>> GetProductsAsync() => await FindAll().ToListAsync();

    public Task<Products> GetProductByIdAsync(Guid id) => GetByIdAsync(id, v => v.Variants);

    public async Task<Products> GetProductByNameAsync(string name) => await FindByCondition(p => p.Name.Equals(name), false, v => v.Variants).SingleOrDefaultAsync();
    public async Task<IEnumerable<Products>> GetAllProductsAsync() => await FindAll(false, v => new { v.Category, v.Brand, v.Material, v.ModelType, v.SoleType, v.Style, }).ToListAsync();


    public Task CreateProductAsync(Products product) => CreateAsync(product);

    public Task UpdateProductAsync(Products product) => UpdateAsync(product);

    public async Task DeleteProductAsync(Guid id)
    {
        var product = await GetProductByIdAsync(id);
        await DeleteAsync(product);
    }
}