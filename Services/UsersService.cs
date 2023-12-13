﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ptm_store_service.Data;
using ptm_store_service.Models;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;

namespace ptm_store_service.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly AppSetting _appSetting; 

        public UsersService(IUserRepository userRepository, IOptionsMonitor<AppSetting> optionsMonitor,
            IConfiguration configuration)
        {
            _userRepository = userRepository;
            _appSetting = optionsMonitor.CurrentValue;
            _configuration = configuration;
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

        public string GenerateRefreshToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
            }
            return Convert.ToBase64String(random);
        }

        public TokenModel GenerateToken(Users users)
        {
            var expiryDuration = new TimeSpan(0, 30, 0);

            try
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, users.ClientName),
                    new Claim(ClaimTypes.NameIdentifier,
                        Guid.NewGuid().ToString())
                };
                var key = _configuration["Jwt:Key"];
                var issuer = _configuration["Jwt:Issuer"];
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
                var tokenDescriptor = new JwtSecurityToken(issuer, issuer, claims,
                    expires: DateTime.Now.Add(expiryDuration), signingCredentials: credentials);

                var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

                return new TokenModel
                {
                    AccessToken = accessToken,
                    RefreshToken = GenerateRefreshToken()
                };
            }
            catch (Exception ex)
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
                if(user != null)
                {
                    var userResponse = new UserResponseModel
                    {
                        Id = user.Id,
                        ClientName = user.ClientName,
                        Email = user.Email,
                        Password = user.Password
                    };
                    return userResponse;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Users GetUserLogin(LoginUserRequest loginUser)
        {
            try
            {
                var user = _userRepository.GetUserByEmailAndPassword(loginUser);
                if(user != null)
                {
                    return user;
                }
                return null;
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
