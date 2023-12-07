using System;

namespace ptm_store_service.Models.Response
{
    public class ProductsResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Status { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public int? CategoryId { get; set; }
    }
}
