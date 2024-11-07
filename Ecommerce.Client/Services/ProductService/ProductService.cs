using System.Net.Http.Json;

using Ecommerce.Client.Model;
using Ecommerce.Domain.Entities.Products;
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

        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            var result = await _http.PostAsJsonAsync("/add", productDto);
            if (result.IsSuccessStatusCode)
            {
                var newProduct = await result.Content.ReadFromJsonAsync<ProductDto>();
                return newProduct;
            }
            else
            {
                var errorContent = await result.Content.ReadAsStringAsync();
                throw new Exception($"Error creating product: {result.StatusCode} - {errorContent}");
            }
        }

        public async Task<ProductDto> GetProductById(Guid id)
        {
            var result = await _http.GetFromJsonAsync<ProductDto>($"/{id}");
            return result;
        }

        public async Task UpdateProduct(ProductDto productDto)
        {
            var result = await _http.PutAsJsonAsync($"/update/{productDto.Id}", productDto); // Gọi API cập nhật sản phẩm
            if (!result.IsSuccessStatusCode)
            {
                var errorContent = await result.Content.ReadAsStringAsync();
                throw new Exception($"Error updating product: {result.StatusCode} - {errorContent}");
            }
        }

        public async Task DeleteProduct(Guid productId)
        {
            var result = await _http.DeleteAsync($"/delete/{productId}"); // Gọi API xóa sản phẩm
            if (!result.IsSuccessStatusCode)
            {
                var errorContent = await result.Content.ReadAsStringAsync();
                throw new Exception($"Error deleting product: {result.StatusCode} - {errorContent}");
            }
        }

        public async Task<List<Brand>> GetAllBrands()
        {
            var result = await _http.GetFromJsonAsync<List<Brand>>("/brands");
            return result;
        }

        public async Task<List<Category>> GetAllCategorys()
        {
            var result = await _http.GetFromJsonAsync<List<Category>>("/categorys");
            return result;
        }

        public async Task<List<ModelTypes>> GetAllModels()
        {
            var result = await _http.GetFromJsonAsync<List<ModelTypes>>("/models");
            return result;
        }

        public async Task<List<Materials>> GetAllMaterials()
        {
            var result = await _http.GetFromJsonAsync<List<Materials>>("/materials");
            return result;
        }

        public async Task<List<Styles>> GetAllStyles()
        {
            var result = await _http.GetFromJsonAsync<List<Styles>>("/styles");
            return result;
        }

        public async Task<List<SoleTypes>> GetAllSoleTypes()
        {
            var result = await _http.GetFromJsonAsync<List<SoleTypes>>("/soletypes");
            return result;
        }

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
