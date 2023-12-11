using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        List<Users> GetUsersSearched(string search);
        Users GetUserById(int id);
        void CreateUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(Users user);
    }
}
