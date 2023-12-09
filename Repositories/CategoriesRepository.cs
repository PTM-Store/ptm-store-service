using Microsoft.EntityFrameworkCore;
using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly MyDbContext _context;

        public CategoriesRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateCategory(Categories category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Categories category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public List<Categories> GetAllCategories()
        {
            var CategoriesList = _context.Categories.ToList();
            return CategoriesList;
        }

        public Categories GetCategoryById(int id)
        {
            var categories = _context.Categories.Find(id);
            return categories;
        }

        public void UpdateCategory(Categories category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }
    }
}
