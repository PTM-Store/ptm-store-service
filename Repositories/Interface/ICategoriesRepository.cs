using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface ICategoriesRepository
    {
        List<Categories> GetAllCategories();
        Categories GetCategoryById(int id);
        void CreateCategory(Categories category);
        void UpdateCategory(Categories category);
        void DeleteCategory(Categories category);
    }
}
