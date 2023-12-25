using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public IActionResult GetCategoriesByProductId (int productId)
        {
            var categories = _categoriesService.GetAllCategoriesByProductId(productId);
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult CreateCategories(CategoriesRequestModel model)
        {
            var category = _categoriesService.CreateCategory(model);
            return Ok(category);
        }
    }
}
