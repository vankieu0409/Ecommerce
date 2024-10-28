using Ecommerce.Client.Model;

namespace Ecommerce.Client.Services.Common;

public interface ICommonService
{
    Task<List<AddressModel>?> GetProvinces();
    Task<List<AddressModel>?> GetDistricts(string idProvince);
    Task<List<AddressModel>?> GetWasds(string idDistrict);
}