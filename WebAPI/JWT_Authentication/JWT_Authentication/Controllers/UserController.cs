using JWT_Authentication.DTO;
using JWT_Authentication.Models;
using JWT_Authentication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService  _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("Register")]
        public ActionResult Register(UserRegisterDto dto)
        {
            var reg = _service.Register(dto);
            return Ok(reg);
        }

        [HttpPost("Login")]
        public ActionResult Login(UserLoginDto dto)
        {
            var log = _service.Login(dto);
            return Ok(log);
        }

        [Authorize]
        [HttpGet("Profile")]
        public ActionResult GetProfile()
        {
            var user = User.Identity.Name;
            return Ok("Welcome" + user);
        }
    }
}
