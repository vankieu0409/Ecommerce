using Ecommerce.Application.DTOs;
using Ecommerce.Shared.Common.Models;

namespace Ecommerce.Application.Interfaces.IServices;

public interface IProductService
{
    Task<PagedList<ProductDto>> GetAllProductAdmin(RequestParams request);
}