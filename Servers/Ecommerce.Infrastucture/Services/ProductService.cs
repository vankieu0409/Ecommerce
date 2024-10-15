﻿using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Infrastructure.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new AggregateException(nameof(productRepository));
    }

    public async Task<PagedList<ProductDto>> GetAllProductAdmin(RequestParams request)
    {
        var products = await _productRepository.GetAllProductsAsync();
        var productDtos = products.Select(p => new ProductDto
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

        });
        var propInfo = typeof(ProductDto).GetProperty(request.PropFilter);
        var filteredProducts = productDtos
            .Where(dto =>
            {
                var value = propInfo?.GetValue(dto, null);
                return value != null && value.Equals(request.SearchTerm);
            });
        var result = await PagedList<ProductDto>.ToPagedList(filteredProducts.AsQueryable(), request.PageIndex, request.PageSize);
        return result;
    }
}