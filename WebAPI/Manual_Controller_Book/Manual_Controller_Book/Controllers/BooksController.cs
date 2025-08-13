using Manual_Controller_Book.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Manual_Controller_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var books = _context.Books.ToList();
            return Ok(books);    // Return all books
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var book = _context.Books.Find(id);
            if(book==null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult Create(Book b)
        {
            _context.Books.Add(b);
            _context.SaveChanges();
            return Ok(b);
        }

        [HttpPut("{id}")]
        public ActionResult Update(Book b,int id)
        {
            if (id != b.Id)
            {
                return BadRequest();
            }
            _context.Books.Update(b);
            _context.SaveChanges();
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var b=_context.Books.Find(id);
            if(b==null) return NotFound();
            _context.Books.Remove(b);
            _context.SaveChanges();
            return Ok("Deleted");
        }
    }
}
