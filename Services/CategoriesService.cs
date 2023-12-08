using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class CategoriesService
    {
        public readonly IRepository<Categories> _repository;
        public CategoriesService(IRepository<Categories> repository) 
        {
            _repository = repository;
        }

       
        public async Task<IEnumerable<Categories>> GetAllCategories()
        {
            return await _repository.GetAll();
            
        }

        public async Task<Categories> GetByIDCategories(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(Categories categories)
        {
            await _repository.Create(categories);
        }

        public async Task Delete(Categories categories)
        {
            await _repository.Delete(categories);
        }
        public async Task Update(Categories categories)
        {
            await _repository.Update(categories);
        }
    }
}
