using System;

namespace ptm_store_service.Models.Request
{
    public class ProductsRequestModel
    {
        public string SKU { get; set; }


        public string Content { get; set; }


        public int ReviewCounts { get; set; }

        public int Stars { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }


        public int OldPrice { get; set; }

        public string Symbols { get; set; }

        public string MainImg { get; set; }
    }
}
