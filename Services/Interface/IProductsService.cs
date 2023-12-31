﻿using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface IProductsService
    {
        List<ProductsResponseModel> GetAllProducts();
        ProductsResponseModel CreateProduct(ProductsRequestModel request);
        ProductsResponseModel GetProductById(int id);
    }
}
