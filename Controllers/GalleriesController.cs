using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleriesController : ControllerBase
    {
        private readonly IGalleriesService _galleriesService;

        public GalleriesController(IGalleriesService galleriesService)
        {
            _galleriesService = galleriesService;
        }

        [HttpGet]
        public IActionResult GetGalleriesByProductId (int productId)
        {
            var galleries = _galleriesService.GetGalleriesByProductId(productId);
            return Ok(galleries);
        }

        [HttpPost]
        public IActionResult CreateGallery(GalleriesRequestModel model)
        {
            var gallery = _galleriesService.CreateGallery(model);
            return Ok(gallery);
        }
    }
}
