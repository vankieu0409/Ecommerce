using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Client.Model;

public class ProductFilter : PagingRequestParameters
{
    private string _itemNo;
    public string ItemNo() => _itemNo;

    public string? PropFilter;

    public void SetItemNo(string itemNo) => _itemNo = itemNo;
    public string? SearchTerm;
}