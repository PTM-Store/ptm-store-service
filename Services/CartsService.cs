using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class CartsService
    {
        private readonly IRepository<Carts> _repository;

        public CartsService(IRepository<Carts> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Carts>> GetAllCarts()
        {
            return await _repository.GetAll();

        }

        public async Task<Carts> GetByIDCarts(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(Carts carts)
        {
            await _repository.Create(carts);
        }

        public async Task Delete(Carts carts)
        {
            await _repository.Delete(carts);
        }
        public async Task Update(Carts carts)
        {
            await _repository.Update(carts);
        }
    }
}
