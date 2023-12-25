using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewsService _reviewsService;

        public ReviewsController(IReviewsService reviewsService)
        {
            _reviewsService = reviewsService;
        }

        [HttpGet]
        public IActionResult GetAllReviewsByProductId (int productId)
        {
            var reviews = _reviewsService.GetReviewsByProductId(productId);
            return Ok(reviews);
        }

        [HttpPost]
        public IActionResult CreateReviews(ReviewsRequestModel model)
        {
            var review = _reviewsService.CreateReview(model);
            return Ok(review);
        }
    }
}
