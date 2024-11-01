using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Enum;
using Ecommerce.Shared.Common.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Xml.Linq;


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

    public async Task<AddProductDto> GetProductById(Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id); // Gọi phương thức từ repository
        if (product == null)
        {
            throw new KeyNotFoundException("Product not found");
        }

        // Lấy thông tin chi tiết của sản phẩm
        var productsList = _productRepository.AsEnumerable(
                v => v.Brand,
                v => v.Category,
                v => v.ModelType,
                v => v.SoleType,
                v => v.Style,
                v => v.Material
                ).Where(p => p.Id == id).ToList();

        // Chuyển đổi Product thành AddProductDto
        var productDto = new AddProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            SKU = product.SKU,
            Category = productsList.FirstOrDefault()?.Category?.Id ?? Guid.Empty, // Gán ID của Category
            Brand = productsList.FirstOrDefault()?.Brand?.Id ?? Guid.Empty, // Gán ID của Brand
            Material = productsList.FirstOrDefault()?.Material?.Id ?? Guid.Empty, // Gán ID của Material
            Model = productsList.FirstOrDefault()?.ModelType?.Id ?? Guid.Empty, // Gán ID của ModelType
            SoleType = productsList.FirstOrDefault()?.SoleType?.Id ?? Guid.Empty, // Gán ID của SoleType
            Style = productsList.FirstOrDefault()?.Style?.Id ?? Guid.Empty // Gán ID của Style
                                                                           // Thêm các thuộc tính khác nếu cần
        };

        return productDto;
    }

    public async Task<AddProductDto> UpdateProduct(AddProductDto productDto)
    {
        var product = await _productRepository.GetByIdAsync(productDto.Id); // Lấy sản phẩm theo ID
        if (product == null)
        {
            throw new KeyNotFoundException("Product not found");
        }

        // Cập nhật các thuộc tính của sản phẩm
        product.Name = productDto.Name;
        product.Description = productDto.Description;
        product.IdCategory = productDto.Category;
        product.Price = productDto.Price;
        product.SKU = productDto.SKU;
        product.IdBrand = productDto.Brand;
        product.IdModel = productDto.Model;
        product.IdMaterial = productDto.Material;
        product.IdGender = productDto.Gender;
        product.IdStyle = productDto.Style;
        product.IdSoleType = productDto.SoleType;

        await _productRepository.UpdateAsync(product); // Gọi phương thức cập nhật từ repository
        await _productRepository.SaveChangesAsync(); // Lưu thay đổi

        return productDto; // Trả về sản phẩm đã cập nhật
    }

    public async Task DeleteProduct(Guid productId)
    {
        var product = await _productRepository.GetByIdAsync(productId); // Lấy sản phẩm theo ID
        if (product == null)
        {
            throw new KeyNotFoundException("Product not found");
        }
        await _productRepository.RemoveAsync(product); // Gọi phương thức xóa
        await _productRepository.SaveChangesAsync(); // Lưu thay đổi
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