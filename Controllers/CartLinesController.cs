using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpPost("{userId}")]
        public IActionResult CreateCartLines([FromRoute]int userId, [FromBody]CartLinesAddingRequest cartLinesRequestModel)
        {
            var cart = _cartsService.GetCartByUserId(userId);
            cartLinesRequestModel.CartId = cart.Id;
            var cartLines = _cartLinesService.CreateCartLine(cartLinesRequestModel);
            return Ok(cartLines);
        }

        [HttpPut("{cartLineId}")]
        public IActionResult UpdateCartLine([FromRoute]int cartLineId, [FromBody]QuantityCartLine quantityCartLine)
        {
            var cartLines = _cartLinesService.UpdateCartLine(cartLineId,quantityCartLine);
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
