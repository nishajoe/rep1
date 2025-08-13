using Microsoft.AspNetCore.Mvc;
using Service_Repo_Crud_Manual.Models;
using Service_Repo_Crud_Manual.Repository;

namespace Service_Repo_Crud_Manual.Services
{
    public class StudentServices:IStudentServices
    {
        private readonly IStudentRepository _repo;

        public StudentServices(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll() => _repo.GetAll();
        public Student GetId(int id) => _repo.GetId(id);
        public void Add(Student s) => _repo.Add(s);
        public void Update(Student s) => _repo.Update(s);
        public void Delete(int id) => _repo.Delete(id);

    }
}
