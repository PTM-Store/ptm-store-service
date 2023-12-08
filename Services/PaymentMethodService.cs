using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class PaymentMethodService
    {
        private readonly IRepository<PaymentMethod> _repository;

        public PaymentMethodService(IRepository<PaymentMethod> repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethod()
        {
            return await _repository.GetAll();

        }

        public async Task<PaymentMethod> GetByIDPaymentMethod(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(PaymentMethod paymentMethod)
        {
            await _repository.Create(paymentMethod);
        }

        public async Task Delete(PaymentMethod paymentMethod)
        {
            await _repository.Delete(paymentMethod);
        }
        public async Task Update(PaymentMethod paymentMethod)
        {
            await _repository.Update(paymentMethod);
        }
    }
}
