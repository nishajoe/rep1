using Service_Repo_Crud_Manual.Models;

namespace Service_Repo_Crud_Manual.Services
{
    public interface IStudentServices
    {
        List<Student> GetAll();
         Student GetId(int id);
       void Add(Student s);
       void Update(Student s);
       void Delete(int id);

    }
}
