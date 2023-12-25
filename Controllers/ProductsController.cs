using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productsService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute]int id)
        {
            var product = _productsService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductsRequestModel model)
        {
            var product = _productsService.CreateProduct(model);
            return Ok(product);
        }
    }
}
