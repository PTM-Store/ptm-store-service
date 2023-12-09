using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ICategoriesService
    {
        List<CategoriesResponseModel> GetAllCategories();
        CategoriesResponseModel GetCategoryById(int id);
        Categories CreateCategory(CategoriesRequestModel categoriesRequest);
        Categories UpdateCategory(CategoriesRequestModel categoriesRequest);
        void DeleteCategory(int id);
    }
}
