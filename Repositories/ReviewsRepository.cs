using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class ReviewsRepository : IReviewsRepository
    {
        private readonly MyDbContext _context;

        public ReviewsRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateReviews(Reviews reviews)
        {
            _context.Reviews.Add(reviews);
            _context.SaveChanges();
        }

        public List<Reviews> GetAllReviewsByProductId(int ProductId)
        {
            var reviewsList = _context.Reviews.Where(re => re.ProductId == ProductId).ToList();
            return reviewsList;
        }
    }
}
