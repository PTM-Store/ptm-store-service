using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repository
{
    public interface IRepository<T>
    {
        
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}

