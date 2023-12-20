using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartLinesController : ControllerBase
    {
        private readonly ICartLinesService cartLinesService;

        public CartLinesController(ICartLinesService cartLinesService)
        {
            this.cartLinesService = cartLinesService;
        }

        
    }
}
