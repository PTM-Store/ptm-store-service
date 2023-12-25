using System.ComponentModel.DataAnnotations;

namespace ptm_store_service.Models.Request
{
    public class ReviewsRequestModel
    {
        public string Name { get; set; }

        public int Stars { get; set; }

        public string Comment { get; set; }

        public string Picture { get; set; }

        public int ProductId { get; set; }
    }
}
