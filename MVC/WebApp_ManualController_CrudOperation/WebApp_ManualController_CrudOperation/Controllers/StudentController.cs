using Microsoft.AspNetCore.Mvc;
using WebApp_ManualController_CrudOperation.Models;

namespace WebApp_ManualController_CrudOperation.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var stud = _context.Students.ToList();
            return View(stud);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student s)
        {
            _context.Students.Add(s);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
           var stud = _context.Students.Find(id);
           return View(stud);
        }

        [HttpPost]
        public IActionResult Edit(Student s) 
        {
            _context.Students.Update(s);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var stud = _context.Students.Find(id);
            return View(stud);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var stud = _context.Students.Find(id);
            _context.Students.Remove(stud);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var stud = _context.Students.Find(id);
            return View(stud);
        }






    }
}
