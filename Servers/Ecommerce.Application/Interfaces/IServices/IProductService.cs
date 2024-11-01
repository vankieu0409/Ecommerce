using Ecommerce.Application.DTOs;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Application.Interfaces.IServices;

public interface IProductService
{
    public Task<PagedList<ProductDto>> GetAllProductAdmin(RequestParams request);
    public Task<AddProductDto> AddProduct(AddProductDto addProductDto);
    public Task<AddProductDto> GetProductById(Guid id);
    public Task<AddProductDto> UpdateProduct(AddProductDto productDto);
    public Task DeleteProduct(Guid productId);
    public Task<IEnumerable<Brand>> GetAllBrandsAsync();
    public Task<IEnumerable<Category>> GetAllCategorysAsync();
    public Task<IEnumerable<ModelTypes>> GetAllModelsAsync();
    public Task<IEnumerable<Materials>> GetAllMaterialsAsync();
    public Task<IEnumerable<Styles>> GetAllStylesAsync();
    public Task<IEnumerable<SoleTypes>> GetAllSoleTypesAsync();
}