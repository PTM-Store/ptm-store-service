using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ICategoriesService
    {
        List<CategoriesResponseModel> GetAllCategoriesByProductId(int productId);
        CategoriesResponseModel GetCategoryById(int id);
        Categories CreateCategory(CategoriesRequestModel categoriesRequest);
        Categories UpdateCategory(CategoriesResponseModel categoriesResponse);
        void DeleteCategory(int id);
    }
}
