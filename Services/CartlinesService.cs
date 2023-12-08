using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class CartlinesService
    {
        private readonly IRepository<CartLines> _repository;

        public CartlinesService(IRepository<CartLines> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CartLines>> GetAllCartLines()
        {
            return await _repository.GetAll();

        }

        public async Task<CartLines> GetByIDCartlines(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(CartLines cartLines)
        {
            await _repository.Create(cartLines);
        }

        public async Task Delete(CartLines cartLines)
        {
            await _repository.Delete(cartLines);
        }
        public async Task Update(CartLines cartLines)
        {
            await _repository.Update(cartLines);
        }
    }
}
