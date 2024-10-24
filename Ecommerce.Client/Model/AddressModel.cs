namespace Ecommerce.Client.Model;

public class AddressModel
{
    public string id { get; set; }
    public string name { get; set; }
    public string name_en { get; set; }
    public string full_name { get; set; }
    public string full_name_en { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
}

public record HanderAddress
{
    public int error { get; init; }
    public string error_text { get; init; }
    public string data_name { get; init; }
    public IEnumerable<AddressModel> data { get; init; }
}

