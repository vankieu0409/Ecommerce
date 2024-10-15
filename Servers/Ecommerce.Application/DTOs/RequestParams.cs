using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Application.DTOs;

public class RequestParams : PagingRequestParameters
{
    public string? PropFilter;
    public string? SearchTerm;
}