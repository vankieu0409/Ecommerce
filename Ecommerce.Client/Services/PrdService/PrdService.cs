using System.Net.Http;
using System.Net.Http.Json;
using Ecommerce.Domain.Entities.Products;
namespace Ecommerce.Client.Services.PrdService
{
    public class PrdService : IPrdService
    {
        private readonly HttpClient _http;
        public PrdService(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            //try
            //{
            //    var response = await _http.GetAsync($"api/Product/all");
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var content = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine($"API Response: {content}");
            //        return await response.Content.ReadFromJsonAsync<List<Products>>();
            //    }
            //    else
            //    {
            //        var errorContent = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine($"API Error: Status {response.StatusCode}, Content: {errorContent}");
            //        return new List<Products>();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Exception in GetAllProducts: {ex.Message}");
            //    return new List<Products>();
            //}

            var response = await _http.GetAsync("/all");
            return await response.Content.ReadFromJsonAsync<List<Products>>();
        }

        public async Task<Products> AddProduct(Products product)
        {
            var result = await _http.PostAsJsonAsync("api/Product", product);
            return await result.Content.ReadFromJsonAsync<Products>();
        }

        public async Task<Products> GetProduct(Guid id)
        {
            var result = await _http.GetFromJsonAsync<Products>($"api/Product/{id}");
            return result;
        }

        public async Task<Products> UpdateProduct(Guid id, Products product)
        {
            var result = await _http.PutAsJsonAsync($"api/Product/{id}", product);
            return await result.Content.ReadFromJsonAsync<Products>();
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var result = await _http.DeleteAsync($"api/Product/{id}");
            return result.IsSuccessStatusCode;
        }
    }
}
