using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class ShippingMethodService
    {
        private readonly IRepository<ShippingMethod> _repository;

        public ShippingMethodService(IRepository<ShippingMethod> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ShippingMethod>> GetAllShippingMethod()
        {
            return await _repository.GetAll();
        }

        public async Task<ShippingMethod> GetByIDShippingMethod(int id)
        {
            return await _repository.GetByID(id);
        }

        public async Task Create(ShippingMethod shippingMethod)
        {
            await _repository.Create(shippingMethod);
        }

        public async Task Update(ShippingMethod shippingMethod)
        {
            await _repository.Update(shippingMethod);
        }

        public async Task Delete(ShippingMethod shippingMethod)
        {
            await _repository.Delete(shippingMethod);
        }
    }
}
