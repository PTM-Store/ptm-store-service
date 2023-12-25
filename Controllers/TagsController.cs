using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagsService _tagsService;

        public TagsController(ITagsService tagsService)
        {
            _tagsService = tagsService;
        }

        [HttpGet]
        public IActionResult GetTagsByProductId(int productId)
        {
            var tags = _tagsService.GetAllTagsByProductId(productId);
            return Ok(tags);
        }

        [HttpPost]
        public IActionResult CreateTags(TagsRequestModel tags)
        {
            var tag = _tagsService.CreateTag(tags);
            return Ok(tag);
        }
    }
}
