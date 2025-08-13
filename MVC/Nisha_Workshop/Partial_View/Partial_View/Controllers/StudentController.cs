using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Partial_View.Models;
using System.Diagnostics;

namespace Partial_View.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentView viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return RedirectToAction("List", "Student");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var student = await _context.Students.ToListAsync();
            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student editStudent)
        {
            var student = await _context.Students.FindAsync(editStudent.Id);
            if (student != null)
            {
                student.Name = editStudent.Name;
                student.Email = editStudent.Email;
                student.Phone = editStudent.Phone;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student deleteStudent)
        {
            var student = await _context.Students.FirstOrDefaultAsync(x => x.Id == deleteStudent.Id);
            if (student != null)
            {
                _context.Students.Remove(deleteStudent);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student");
        }


    }
}
