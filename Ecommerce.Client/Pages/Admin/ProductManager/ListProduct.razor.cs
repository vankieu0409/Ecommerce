﻿using Ecommerce.Client.Model;
using Ecommerce.Client.Services.ProductService;
using Ecommerce.Shared.Common.Models;

using Microsoft.AspNetCore.Components;

using MudBlazor;

namespace Ecommerce.Client.Pages.Admin.ProductManager;

public partial class ListProduct : ComponentBase
{
    private PagedList<ProductDto> productDtos;
    [Parameter] public int pageIndex { get; set; } = 1;
    [Parameter] public int pageSize { get; set; } = 10;

    private bool dialogVisible;
    private DialogOptions dialogOptions = new() { FullWidth = true };
    private ProductDto newProductDto = new ProductDto();

    protected override async Task OnInitializedAsync()
    {
        await LoadProducts();
    }
    private async Task LoadProducts()
    {
        var request = new ProductFilter()
        {
            PageIndex = pageIndex,
            PageSize = pageSize
        };
        productDtos = await _productService.GetAdminProducts(request);
    }
    private void OpenDialog()
    {
        newProductDto = new ProductDto();
        dialogVisible = true;
    }

    private void NavigateToUpdate(Guid productId)
    {
        NavigationManager.NavigateTo($"/Admin/Product/Update/{productId}");
    }

    private void Cancel()
    {
        dialogVisible = false;
    }

    private void Submit()
    {
        productDtos.Add(newProductDto);
        dialogVisible = false;
    }

    private void EditProductDto(ProductDto ProductDto)
    {
        // Implement edit logic
    }

    private async Task DeleteProductDto(ProductDto productDto)
    {
        /*await _productService.DeleteProduct(productDto.Id); */// Gọi phương thức xóa sản phẩm
        productDtos.Remove(productDto);
        // cập nhật dữ liệu trong database
    }
}
