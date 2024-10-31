using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Enum;
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
            //request.PageSize = 1;
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

    public async Task<AddProductDto> AddProduct(AddProductDto productDto)
    {
        try
        {
            var product = new Products
            {
                Name = productDto.Name,
                Description = productDto.Description,
                IdCategory = productDto.Category,
                Price = productDto.Price,
                SKU = productDto.SKU,
                IdBrand = productDto.Brand,
                IdModel = productDto.Model,
                IdMaterial = productDto.Material,
                IdGender = productDto.Gender,
                IdStyle = productDto.Style,
                IdSoleType = productDto.SoleType,
                ReleaseDate = productDto.ReleaseDate,
                // Set other properties as needed
            };

            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();

            return productDto; // Return the added product DTO
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var brandsList = _productRepository.AsEnumerable(v => v.Brand)
                .GroupBy(b => b.Brand.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var brandDtos = brandsList.Select(b => new Brand
            {
                Id = b.Brand.Id,
                BrandName = b.Brand.BrandName,
            }).ToList();

            return brandDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Category>> GetAllCategorysAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var categorysList = _productRepository.AsEnumerable(v => v.Category)
                .GroupBy(b => b.Category.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var categoryDtos = categorysList.Select(b => new Category
            {
                Id = b.Category.Id,
                Name = b.Category.Name,
            }).ToList();

            return categoryDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<ModelTypes>> GetAllModelsAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var modelsList = _productRepository.AsEnumerable(v => v.ModelType)
                .GroupBy(b => b.ModelType.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var modelsDtos = modelsList.Select(b => new ModelTypes
            {
                Id = b.ModelType.Id,
                ModelType = b.ModelType.ModelType,
            }).ToList();

            return modelsDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Materials>> GetAllMaterialsAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var materialsList = _productRepository.AsEnumerable(v => v.Material)
                .GroupBy(b => b.Material.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var materialsDtos = materialsList.Select(b => new Materials
            {
                Id = b.Material.Id,
                MaterialType = b.Material.MaterialType,
            }).ToList();

            return materialsDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Styles>> GetAllStylesAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var stylesList = _productRepository.AsEnumerable(v => v.Style)
                .GroupBy(b => b.Style.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var categoryDtos = stylesList.Select(b => new Styles
            {
                Id = b.Style.Id,
                Style = b.Style.Style,
            }).ToList();

            return categoryDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public async Task<IEnumerable<SoleTypes>> GetAllSoleTypesAsync()
    {
        try
        {
            // Lấy danh sách các thương hiệu
            var solestylesList = _productRepository.AsEnumerable(v => v.SoleType)
                .GroupBy(b => b.SoleType.Id) // Nhóm theo Id thương hiệu
                .Select(g => g.First()) // Lấy mục đầu tiên trong mỗi nhóm
                .ToList(); // Chuyển đổi thành danh sách
            var categoryDtos = solestylesList.Select(b => new SoleTypes
            {
                Id = b.SoleType.Id,
                SoleType = b.SoleType.SoleType,
            }).ToList();

            return categoryDtos;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

}