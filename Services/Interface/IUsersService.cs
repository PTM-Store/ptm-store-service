using ptm_store_service.Data;
using ptm_store_service.Models;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface IUsersService
    {
        List<UserResponseModel> GetAllUsers();
        UserResponseModel GetUserById(int id);
        Users GetUserLogin(LoginUserRequest loginUser);
        Users CreateUser(UsersRequestModel usersRequest);
        Users UpdateUser(UserResponseModel userResponseModel);
        void DeleteUser(int id);
        TokenResponseModel GenerateToken(Users loginUser);
        string GenerateRefreshToken();
    }
}
