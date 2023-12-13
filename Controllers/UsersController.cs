using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ptm_store_service.Models;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost("Login")]
        public IActionResult Validate(LoginUserRequest loginUser)
        {
            var user = _usersService.GetUserLogin(loginUser);
            if (user == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid user",
                    Data = null
                });
            }
            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Authenticate success",
                Data = _usersService.GenerateToken(user)
            });
        }
    }
}
