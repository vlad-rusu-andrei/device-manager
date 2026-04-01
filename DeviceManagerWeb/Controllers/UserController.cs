using DeviceManager.manager.dto;
using DeviceManager.manager.entity;
using DeviceManager.manager.service;
using Microsoft.AspNetCore.Mvc;


namespace DeviceManagerWeb.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        // GET users api/v1/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        // GET user api/v1/users/400
        [HttpGet("{id}")]
        public IActionResult GetUser(uint  id)
        {
            var user = _userService.GetUserById(id);
            if(user == null) return NotFound();

            return Ok(user);
        }

        // POST user api/v1/users
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok(user);
        }

        // POST update user api/v1/users/400
        [HttpPost("{id}")]
        public IActionResult UpdateUser(UserDTO user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        // DELETE user api/v1/users/400
        [HttpDelete]
        public IActionResult DeleteUser(uint id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
    }
}
