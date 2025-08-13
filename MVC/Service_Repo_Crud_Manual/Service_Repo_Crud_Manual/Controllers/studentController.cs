using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Service_Repo_Crud_Manual.Models;
using Service_Repo_Crud_Manual.Services;

namespace Service_Repo_Crud_Manual.Controllers
{
    public class studentController : Controller
    {
        private readonly IStudentServices _service;

        public studentController(IStudentServices service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var stud = _service.GetAll();
            return View(stud);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student s)
        {
            _service.Add(s);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var student = _service.GetId(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            _service.Update(s);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var s=_service.GetId(id);
            return View(s);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }

       
}
