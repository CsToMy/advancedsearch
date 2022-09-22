using Common;
using Microsoft.AspNetCore.Mvc;
using SportsStoreWebAPI.Interfaces;

namespace SportsStoreWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getCategories")]
        public IActionResult GetCategories()
        {
            var result = _productService.GetProductCategories();
            return Ok(result);
        }

        [HttpGet("getProducts/{category?}")]
        public IActionResult GetProducts(string? category = null)
        {
            var result = _productService.GetProducts(category??string.Empty);
            return Ok(result);
        }

        [HttpPost("searchProduct")]
        public IActionResult SearchProduct([FromBody]ProductExt productFilter)
        {
            var result = _productService.SearchProduct(productFilter);
            return Ok(result);
        }
    }
}
