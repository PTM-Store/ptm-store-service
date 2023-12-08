using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class ProductsService 
    {
        private readonly IRepository<Products> _repository;

        public ProductsService(IRepository<Products> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Products>> GetAllProducts()
        {
            return await _repository.GetAll();
        }

        public async Task<Products> GetProductById(int id)
        {
            return await _repository.GetByID(id);
        }

        public async Task CreateProducts(Products products)
        {
            await _repository.Create(products);  
        }

        public async Task DeleteProducts(Products products)
        {
            await _repository.Delete(products);
        }

        public async Task UpdateProducts(Products products)
        {
            await _repository.Update(products);
        }
    }
}
