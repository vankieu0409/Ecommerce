using Ecommerce.API.ViewModels;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IServices;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new AggregateException(nameof(productService));
        }

        [HttpGet()]
        [Route("/admin")]
        public async Task<IActionResult> GetAllProductAdmin([FromQuery] ProductFilterViewModel query)
        {
            var request = new RequestParams() { PageIndex = query.PageIndex, PageSize = query.PageSize, PropFilter = query.PropFilter, SearchTerm = query.SearchTerm };
            var products = await _productService.GetAllProductAdmin(request);
            return Ok(products);
        }
    }
}
