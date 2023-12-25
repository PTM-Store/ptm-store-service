using ptm_store_service.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ptm_store_service.Models.Response
{
    public class ProductsResponseModel
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Content { get; set; }
        
        public int ReviewCounts { get; set; }

        public int Stars { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }

        
        public int OldPrice { get; set; }

        public string Symbols { get; set; }

        public string MainImg { get; set; }

        public List<CategoriesResponseModel> Categories { get; set; }

        public List<TagsResponseModel> Tags { get; set; }

        public List<ReviewsResponseModel> Reviews { get; set; }

        public List<GalleriesResponseModel> Gallery { get; set; }
    }
}
