using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IEmailService _emailService;
        private readonly ICartsService _cartsService;
        private readonly ITokenService _tokenService;

        public UsersController(IUsersService usersService, IEmailService emailService, ICartsService cartsService, ITokenService tokenService)
        {
            _usersService = usersService;
            _emailService = emailService;
            _cartsService = cartsService;
            _tokenService = tokenService;
        }

        [HttpPost("Login")]
        public IActionResult Validate([FromBody]LoginUserRequest loginUser)
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
            return Ok(_usersService.GenerateToken(user));
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] UsersRequestModel usersRequest)
        {
            var user = _usersService.CreateUser(usersRequest);
            if(user != null)
            {
                var cartRequest = new CartsRequestModel
                {
                    UserId = user.Id,
                };
                var cart = _cartsService.CreateCart(cartRequest);
            }
            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Register successfully!!!",
                Data = user
            });
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetUserInfo([FromRoute]int id)
        {
            var user = _usersService.GetUserById(id);
            return Ok(user);
        }
    }
}
