using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class VariantsService
    {
        private readonly IRepository<Variants> _repository;

        public VariantsService(IRepository<Variants> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Variants>> GetAllVariants()
        {
            return await _repository.GetAll();

        }

        public async Task<Variants> GetByIDVariants(int id)
        {
            return await _repository.GetByID(id);
            
        }

        public async Task Create(Variants variants)
        {
            await _repository.Create(variants);
        }

        public async Task Delete(Variants variants)
        {
            await _repository.Delete(variants);
        }
        public async Task Update(Variants variants)
        {
            await _repository.Update(variants);
        }
    }
}
