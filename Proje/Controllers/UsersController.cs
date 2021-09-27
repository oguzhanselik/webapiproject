using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Proje.Services;
using Proje.Models;
using System;

namespace Proje.Controllers
{
    [Authorize]
    [ApiController]
    [Route("secret")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;


        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateModel model = null)
        {
            if (model == null)
            {
                return Unauthorized();
            }
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(user);
        }

        [HttpGet]
        public String Index()
        {
            return "SUCCESS";

        }



    }
}