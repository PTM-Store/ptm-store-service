using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class OrdersService
    {
        private readonly IRepository<Orders> _repository;

        public OrdersService(IRepository<Orders> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Orders>> GetAllOrders()
        {
            return await _repository.GetAll();

        }

        public async Task<Orders> GetByIDOrder(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(Orders orders)
        {
            await _repository.Create(orders);
        }

        public async Task Delete(Orders orders)
        {
            await _repository.Delete(orders);
        }
        public async Task Update(Orders orders)
        {
            await _repository.Update(orders);
        }
    }
}
