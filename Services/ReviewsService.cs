using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Services
{
    public class ReviewsService : IReviewsService
    {
        private readonly IReviewsRepository _reviewsRepository;

        public ReviewsService(IReviewsRepository reviewsRepository)
        {
            _reviewsRepository = reviewsRepository;
        }

        public ReviewsResponseModel CreateReview(ReviewsRequestModel request)
        {
            var review = new Reviews
            {
                Name = request.Name,
                Stars = request.Stars,
                Comment = request.Comment,
                Picture = request.Picture,
                ProductId = request.ProductId,
            };
            _reviewsRepository.CreateReviews(review);
            var reviewResponse = new ReviewsResponseModel
            {
                Id = review.Id,
                Name = review.Name,
                Stars = review.Stars,
                Comment = review.Comment,
                Picture = review.Picture,
                ProductId = (int)review.ProductId
            };
            return reviewResponse;
        }

        public List<ReviewsResponseModel> GetReviewsByProductId(int productId)
        {
            var reviews = _reviewsRepository.GetAllReviewsByProductId(productId);
            var reviewsResponse = reviews.Select(re => new ReviewsResponseModel
            {
                Id = re.Id,
                Name = re.Name,
                Stars = re.Stars,
                Comment = re.Comment,
                Picture = re.Picture,
                ProductId = (int)re.ProductId
            });
            return reviewsResponse.ToList();
        }
    }
}
