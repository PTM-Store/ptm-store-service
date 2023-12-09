using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _userRepository;

        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Users CreateUser(UsersRequestModel usersRequest)
        {
            try
            {
                var user = new Users
                {
                    ClientName = usersRequest.ClientName,
                    Email = usersRequest.Email,
                    Password = usersRequest.Password
                };
                _userRepository.CreateUser(user);
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var user = _userRepository.GetUserById(id);
                _userRepository.DeleteUser(user);
            }   
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<UserResponseModel> GetAllUsers()
        {
            try
            {
                var users = _userRepository.GetAllUsers();
                var usersResponse = users.Select(user => new UserResponseModel
                {
                    Id = user.Id,
                    ClientName = user.ClientName,
                    Email = user.Email,
                    Password = user.Password
                });
                return usersResponse.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public UserResponseModel GetUserById(int id)
        {
            try
            {
                var user = _userRepository.GetUserById(id);
                var userResponse = new UserResponseModel
                {
                    Id = user.Id,
                    ClientName = user.ClientName,
                    Email = user.Email,
                    Password = user.Password
                };
                return userResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Users UpdateUser(UserResponseModel userResponseModel)
        {
            try
            {
                var user = _userRepository.GetUserById(userResponseModel.Id);
                if(user != null)
                {
                    user.ClientName = userResponseModel.ClientName;
                    user.Email = userResponseModel.Email;
                    user.Password = userResponseModel.Password;
                    _userRepository.UpdateUser(user);
                    return user;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
