using Ecommerce.API.ViewModels;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;

        public ProductController(IProductService productService, ApplicationDbContext dbContext)
        {
            _productService = productService ?? throw new AggregateException(nameof(productService));
            _context = dbContext;
        }

        [HttpGet()]
        [Route("/admin")]
        public async Task<IActionResult> GetAllProductAdmin([FromQuery] ProductFilterViewModel query)
        {
            var request = new RequestParams() { PageIndex = query.PageIndex, PageSize = query.PageSize, PropFilter = query.PropFilter, SearchTerm = query.SearchTerm };
            var products = await _productService.GetAllProductAdmin(request);
            return Ok(products);
        }

        

        // GET: api/Product/5
        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var product = _context.Products.Find(id);
            return Ok(product);
        }

        // PUT: api/Product/5
        //[HttpPut("id")]
        //public IActionResult Put(Guid id, ProductDto prd)
        //{
        //    var product = _context.Products.Find(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    product.Name = prd.Name;
        //    product.IdCategory = prd.IdCategory;
        //    product.Description = prd.Description;
        //    product.IdBrand = prd.IdBrand;
        //    product.IdModel = prd.IdModel;
        //    product.IdMaterial = prd.IdMaterial;
        //    product.IdGender = prd.IdGender;
        //    product.IdStyle = prd.IdStyle;
        //    product.IdSoleType = prd.IdSoleType;
        //    product.ReleaseDate = prd.ReleaseDate;
        //    product.SKU = prd.SKU;
        //    product.Price = prd.Price;

        //    _context.Entry(product).State = EntityState.Modified;
        //    _context.SaveChanges();

        //    return Ok("Cập nhật sản phẩm thành công");
        //}

        // DELETE: api/Product/5
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _productService.DeleteProduct(id); // Gọi phương thức xóa từ ProductService
                return Ok("Product deleted successfully");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Product not found");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPost]
        [Route("/add")]
        public async Task<IActionResult> AddProduct(ProductDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest("Product data is null.");
            }

            var result = await _productService.AddProduct(productDto);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            try
            {
                var product = await _productService.GetProductById(id); // Gọi phương thức từ service
                return Ok(product);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Product not found");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut]
        [Route("/update/{id}")]
        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] ProductDto productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest("Product ID mismatch");
            }

            try
            {
                var updatedProduct = await _productService.UpdateProduct(productDto); // Gọi phương thức cập nhật từ ProductService
                return Ok(updatedProduct);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Product not found");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpDelete]
        [Route("/delete/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                await _productService.DeleteProduct(id); // Gọi phương thức xóa từ ProductService
                return Ok("Product deleted successfully");
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Product not found");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/brands")]
        public async Task<IActionResult> GetBrands()
        {
            try
            {
                var brands = await _productService.GetAllBrandsAsync();
                return Ok(brands);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/categorys")]
        public async Task<IActionResult> GetCategorys()
        {
            try
            {
                var categorys = await _productService.GetAllCategorysAsync();
                return Ok(categorys);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/models")]
        public async Task<IActionResult> GetModels()
        {
            try
            {
                var models = await _productService.GetAllModelsAsync();
                return Ok(models);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/materials")]
        public async Task<IActionResult> Getmaterials()
        {
            try
            {
                var materials = await _productService.GetAllMaterialsAsync();
                return Ok(materials);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/styles")]
        public async Task<IActionResult> GetStyles()
        {
            try
            {
                var styles = await _productService.GetAllStylesAsync();
                return Ok(styles);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpGet]
        [Route("/soletypes")]
        public async Task<IActionResult> GetSoleTypes()
        {
            try
            {
                var soletypes = await _productService.GetAllSoleTypesAsync();
                return Ok(soletypes);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}
