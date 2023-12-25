using ptm_store_service.Data;
using System.Collections.Generic;

namespace ptm_store_service.Repositories.Interface
{
    public interface IReviewsRepository
    {
        void CreateReviews(Reviews reviews);
        List<Reviews> GetAllReviewsByProductId(int productId);
    }
}
