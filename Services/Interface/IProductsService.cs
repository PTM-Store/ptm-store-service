using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface IProductsService
    {
        List<ProductsResponseModel> GetAllProducts();
        ProductsResponseModel GetProductsById(int id);
        Products CreateProduct(ProductsRequestModel productsRequest);
        Products UpdateProduct(ProductsRequestModel productsRequest);
        void DeleteProduct(int id);
    }
}
