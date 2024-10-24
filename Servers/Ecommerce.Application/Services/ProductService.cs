using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Shared.Common.Models;

using Microsoft.Extensions.Logging;


namespace Ecommerce.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly ILogger<ProductService> _logger;

    public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
    {
        _productRepository = productRepository ?? throw new AggregateException(nameof(productRepository));
        _logger = logger ?? throw new AggregateException(nameof(logger));
    }

    public async Task<PagedList<ProductDto>> GetAllProductAdmin(RequestParams request)
    {
        try
        {
            request.PageSize = 1;
            var productsList = _productRepository.AsEnumerable(
                v => v.Brand,
                v => v.ModelType,
                v => v.SoleType,
                v => v.Style,
                v => v.Material
                );
            var productDtos = productsList.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description ?? "",
                Price = p.Price,
                SKU = p.SKU,
                Brand = p.Brand.BrandName,
                Material = p.Material.MaterialType,
                ModelType = p.ModelType.ModelType,
                SoleType = p.SoleType.SoleType,
                Style = p.Style.Style

            }).ToList();
            if (!string.IsNullOrEmpty(request.PropFilter))
            {
                var propInfo = typeof(ProductDto).GetProperty(request.PropFilter);
                //var filteredProducts = productDtos
                //    .Where(dto =>
                //    {
                //        var value = propInfo?.GetValue(dto, null);
                //        return value != null && value.Equals(request.SearchTerm);
                //    });
            }
            var result = await PagedList<ProductDto>.ToPagedList(productDtos, request.PageIndex, request.PageSize);
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }
}