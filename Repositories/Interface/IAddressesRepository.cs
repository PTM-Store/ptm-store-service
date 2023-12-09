using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface IAddressesRepository
    {
        Task<IEnumerable<Addresses>> GetAllAddresses();
        Task<Addresses> GetAddressById(int id);
        Task CreateAddress(Addresses Address);
        Task UpdateAddress(Addresses Address);
        Task DeleteAddress(Addresses Address);
    }
}
