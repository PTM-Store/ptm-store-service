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

        [HttpGet("{categoryId}")]
        [Authorize]
        public IActionResult GetProductsByCateId([FromRoute]int categoryId)
        {
            var productsResponse = _productsService.GetProductsByCategoryId(categoryId);
            return Ok(productsResponse);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody]ProductsRequestModel productsRequestModel)
        {
            var product = _productsService.CreateProduct(productsRequestModel);
            return Ok(product);
        }
    }
}
