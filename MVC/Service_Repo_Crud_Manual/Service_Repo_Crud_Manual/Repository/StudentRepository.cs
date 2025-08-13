using Service_Repo_Crud_Manual.Data;
using Service_Repo_Crud_Manual.Models;

namespace Service_Repo_Crud_Manual.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll() => _context.Students.ToList();

        public Student GetId(int id) => _context.Students.Find(id);

        public void Add(Student stud)
        {
            _context.Students.Add(stud);
            _context.SaveChanges();
        }
        public void Update(Student stud)
        {
            _context.Students.Update(stud);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var s= _context.Students.Find(id);
            if(s!=null)
            {
                _context.Students.Remove(s);
                _context.SaveChanges();
            } 
        }
    }
}
