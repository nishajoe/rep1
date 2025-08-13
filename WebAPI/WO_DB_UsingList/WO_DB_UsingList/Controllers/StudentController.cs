using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WO_DB_UsingList.Models;

namespace WO_DB_UsingList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student{ Id=1, Name = "Akhil", Age=20 },
            new Student{ Id=2, Name = "Reena", Age=21 },
            new Student{ Id=3, Name = "Megha", Age=40 },
            new Student{ Id=4, Name = "Veena", Age=30 },
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var s = students.FirstOrDefault(n => n.Id == id);
            return s == null ? NotFound() : Ok(s);
        }


        [HttpPost]
        public IActionResult Create(Student stud)
        {
            stud.Id = students.Count + 1;
            students.Add(stud);
            return Ok(stud);  //students check
        }


        [HttpPut("{id}")]
        public IActionResult Update(Student stud, int id)
        {
            var s = students.FirstOrDefault(n => n.Id == id);
            if(s== null)
                return NotFound();
            s.Name = stud.Name;
            s.Age = stud.Age;
            return Ok(s);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var s = students.FirstOrDefault(n=>n.Id== id);
            if (s == null) return NotFound();
            students.Remove(s);
            return Ok("Deleted");
        }
    }
}
