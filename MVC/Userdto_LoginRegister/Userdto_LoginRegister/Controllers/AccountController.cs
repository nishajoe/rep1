using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Userdto_LoginRegister.Models;

namespace Userdto_LoginRegister.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AccountController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //GET
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Userdto userDto)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(userDto);
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(userDto);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Userdto udto)
        {
            var user=_context.Users.FirstOrDefault(u=>u.Email == udto.Email && u.Password == udto.Password);
            if(user!=null)
            {
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(udto);
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
