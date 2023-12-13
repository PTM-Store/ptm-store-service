using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(CategoriesRequestModel categoriesRequestModel)
        {
            var category = _categoriesService.CreateCategory(categoriesRequestModel);
            return Ok(category);
        }
    }
}
