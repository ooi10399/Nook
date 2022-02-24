using GatewayAPI.Models;
using GatewayAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IManageUser<UserDTO> _manageUser;
        public UserController(IManageUser<UserDTO> manageUser)
        {
            _manageUser = manageUser;
        }
        
        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(UserDTO user)
        {
            var myUser = await _manageUser.Add(user);

            if (myUser == null)
                return BadRequest("Unable to register user");
            return Ok(myUser);
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(UserDTO user)
        {
            var myUser = await _manageUser.Login(user);

            if (myUser == null)
                return BadRequest("Invalid username or password");
            return Ok(myUser);
        }
    }
}
