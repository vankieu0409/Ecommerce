using System.Net.Http.Json;

using Ecommerce.Client.Model;

namespace Ecommerce.Client.Services.Common;

public class CommonService : ICommonService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<CommonService> _logger;
    private string URL = "https://esgoo.net/api-tinhthanh";

    public CommonService(HttpClient httpClient, ILogger<CommonService> logger)
    {
        _httpClient = httpClient ?? throw new AggregateException(nameof(httpClient));
        _logger = logger;
    }
    public async Task<List<AddressModel>?> GetProvinces()
    {

        var result = await _httpClient.GetFromJsonAsync<HanderAddress>(URL + $"/1/0.htm");

        return result?.data.ToList();
    }

    public async Task<List<AddressModel>?> GetDistricts(string idProvince)
    {
        var result = await _httpClient.GetFromJsonAsync<HanderAddress>(URL + $"/2/{idProvince}.htm");
        return result?.data.ToList();
    }

    public async Task<List<AddressModel>?> GetWasds(string idDistrict)
    {
        var result = await _httpClient.GetFromJsonAsync<HanderAddress>(URL + $"/3/{idDistrict}.htm");
        return result?.data.ToList();
    }
}