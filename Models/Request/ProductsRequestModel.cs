using System;

namespace ptm_store_service.Models.Request
{
    public class ProductsRequestModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Status { get; set; }

        public int? CategoryId { get; set; }
    }
}
