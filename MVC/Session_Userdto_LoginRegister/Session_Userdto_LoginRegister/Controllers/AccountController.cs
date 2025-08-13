using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Session_Userdto_LoginRegister.Models;

namespace Session_Userdto_LoginRegister.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AccountController(AppDbContext context, IMapper mapper)
        {
            _context=context;
            _mapper=mapper;
        }

        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(UserDto dto)
        {
            var usr = _mapper.Map<User>(dto);
            _context.Users.Add(usr);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(UserDto dto)
        {
            var user=_context.Users.FirstOrDefault(u =>
                u.Username == dto.Username && u.Password == dto.Password);
            if (user != null)
            {
                HttpContext.Session.SetString("username", user.Username);
                return RedirectToAction("Dashboard");
            }
            ViewBag.Error = "Invalid Login";
            return View();

        }
        //get:dashboard
        public IActionResult Dashboard()
        {
            var usern = HttpContext.Session.GetString("username");
            if (usern == null)
                return RedirectToAction("Login");
            ViewBag.Username = usern;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
