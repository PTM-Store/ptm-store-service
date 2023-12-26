using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartLinesController : ControllerBase
    {
        private readonly ICartLinesService _cartLinesService;
        private readonly ICartsService _cartsService;

        public CartLinesController(ICartLinesService cartLinesService, ICartsService cartsService)
        {
            _cartLinesService = cartLinesService;
            _cartsService = cartsService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetCartLinesByUserId([FromRoute]int userId)
        {
            var cart = _cartsService.GetCartByUserId(userId);
            var cartLines = _cartLinesService.GetCartLinesByCartId(cart.Id);
            return Ok(cartLines);
        }

        [HttpPost]
        public IActionResult CreateCartLines(CartLinesRequestModel cartLinesRequestModel)
        {
            var cartLines = _cartLinesService.CreateCartLine(cartLinesRequestModel);
            return Ok(cartLines);
        }

        [HttpPut]
        public IActionResult UpdateCartLine(CartLinesRequestModel cartLinesRequestModel)
        {
            var cartLines = _cartLinesService.UpdateCartLine(cartLinesRequestModel);
            return Ok(cartLines);
        }

        [HttpDelete("{cartLineId}")]
        public IActionResult DeleteCartLine([FromRoute]int cartLineId)
        {
            _cartLinesService.DeleteCartLine(cartLineId);
            return NoContent();
        }
    }
}
