using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantsController : ControllerBase
    {
        private readonly IVariantsService _variantsService;

        public VariantsController(IVariantsService variantsService)
        {
            _variantsService = variantsService;
        }

        [HttpGet("{productId}")]
        public IActionResult GetVariants([FromRoute]int productId)
        {
            var variants = _variantsService.GetVariantsByProductId(productId);
            return Ok(variants);
        }

        [HttpPost]
        public IActionResult CreateVariant(VariantsRequestModel variants)
        {
            var variant = _variantsService.CreateVariant(variants);
            return Ok(variant);
        }
    }
}
