using System.ComponentModel.DataAnnotations;

namespace ptm_store_service.Models.Response
{
    public class ReviewsResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stars { get; set; }

        public string Comment { get; set; }

        public string Picture { get; set; }

        public int ProductId { get; set; }
    }
}
