using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface IProductsRepository
    {
        List<Products> GetAllProducts();
        Products GetProductsById(int id);
        void CreateProduct(Products product);
        void UpdateProduct(Products product);
        void DeleteProduct(Products product);
        List<Products> GetProductsByCategoryId(int categoryId);
    }
}
