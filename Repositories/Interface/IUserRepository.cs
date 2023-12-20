using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface IUserRepository
    {
        List<Users> GetAllUsers();
        Users GetUserById(int id);
        Users GetUserByEmailAndPassword(LoginUserRequest loginUser);
        Users GetUserByEmail(string email);
        void CreateUser(Users user);
        void UpdateUser(Users user);
        void DeleteUser(Users user);
    }
}
