using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class AddressService
    {
        private readonly IRepository<Addresses> _repository;

        public AddressService(IRepository<Addresses> repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<Addresses>> GetAllAddresses()
        {
            return await _repository.GetAll();

        }

        public async Task<Addresses> GetByIDAddresses(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(Addresses addresses)
        {
            await _repository.Create(addresses);
        }

        public async Task Delete(Addresses addresses)
        {
            await _repository.Delete(addresses);
        }
        public async Task Update(Addresses addresses)
        {
            await _repository.Update(addresses);
        }
    }
}
