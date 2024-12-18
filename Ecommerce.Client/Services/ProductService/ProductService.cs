﻿using System.Net.Http.Json;

using Ecommerce.Client.Model;
using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        //public List<ProductEntity>? Products { get; set; } = new List<ProductEntity>();
        public string Message { get; set; } = "Loading products...";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;
        //public List<ProductEntity> AdminProducts { get; set; }

        //public event Action ProductsChanged;

        //public async Task<ProductEntity> CreateProduct(ProductEntity product)
        //{
        //    var result = await _http.PostAsJsonAsync("api/product", product);
        //    var newProduct = (await result.Content
        //        .ReadFromJsonAsync<ProductEntity>());
        //    return newProduct;
        //}

        //public async Task DeleteProduct(Guid product)
        //{
        //    var result = await _http.DeleteAsync($"api/product/{product}");
        //}

        public async Task<PagedList<ProductDto>> GetAdminProducts(ProductFilter? query)
        {
            var url = query != null ? $"admin?PageIndex={query.PageIndex}&PageSize={query.PageSize}&PropFilter={Uri.EscapeDataString(query.PropFilter ?? "")}&SearchTerm={Uri.EscapeDataString(query.SearchTerm ?? "")}" : $"/admin";

            try
            {
                var respone = await _http.GetFromJsonAsync<List<ProductDto>>($"{url}");
                var result = new PagedList<ProductDto>(respone, 5, query.PageIndex, query.PageSize);


                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            //var result = await _http.GetStringAsync($"api/Product/{url}");
            //var traRa = JsonSerializer.Deserialize<PagedList<ProductDto>>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        }

        //public async Task<ProductEntity> GetProduct(Guid productId)
        //{
        //    var result = await _http.GetFromJsonAsync<ProductEntity>($"api/Product/{productId}");
        //    return result;
        //}

        //public async Task<List<ProductEntity>> GetProducts(string? categoryUrl = null)
        //{
        //    var result = categoryUrl == null ?
        //        await _http.GetFromJsonAsync<List<ProductEntity>>("/api/Product/featured") :
        //        await _http.GetFromJsonAsync<List<ProductEntity>>($"api/Product/category/{categoryUrl}");
        //    return result;
        //}

        //public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        //{
        //    var result = await _http
        //        .GetFromJsonAsync<List<string>>($"api/Product/searchsuggestions/{searchText}");
        //    return result;
        //}

        //public async Task SearchProducts(string searchText, int page)
        //{
        //    LastSearchText = searchText;
        //    var result = await _http
        //         .GetFromJsonAsync<ProductSearchResult>($"api/Product/search/{searchText}/{page}");
        //    if (result != null && result != null)
        //    {
        //        Products = result.Products;
        //        CurrentPage = result.CurrentPage;
        //        PageCount = result.Pages;
        //    }
        //    if (Products.Count == 0) Message = "No products found.";
        //}

        //public async Task<ProductEntity> UpdateProduct(ProductEntity product)
        //{
        //    var result = await _http.PutAsJsonAsync($"api/Product", product);
        //    var content = await result.Content.ReadFromJsonAsync<ProductEntity>();
        //    return content;
        //}
    }
}
