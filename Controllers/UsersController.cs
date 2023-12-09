using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ptm_store_service.Models.Request;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            var UserList = _usersService.GetAllUsers();
            return Ok(UserList);
        }

        [HttpPost]
        public IActionResult Create(UsersRequestModel usersRequestModel)
        {
            if (usersRequestModel == null)
            {
                return BadRequest();
            }
            var user = _usersService.CreateUser(usersRequestModel);
            return Ok(user);
        }
    }
}
