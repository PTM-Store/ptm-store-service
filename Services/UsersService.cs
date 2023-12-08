using ptm_store_service.Data;
using ptm_store_service.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Services
{
    public class UsersService
    {
        private readonly IRepository<Users> _repository;

        public UsersService(IRepository<Users> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Users>> GetAllCarts()
        {
            return await _repository.GetAll();

        }

        public async Task<Users> GetByIDCarts(int id)
        {
            var cate = await _repository.GetByID(id);
            return cate;
        }

        public async Task Create(Users users)
        {
            await _repository.Create(users);
        }

        public async Task Delete(Users users)
        {
            await _repository.Delete(users);
        }
        public async Task Update(Users users)
        {
            await _repository.Update(users);
        }
    }
}
