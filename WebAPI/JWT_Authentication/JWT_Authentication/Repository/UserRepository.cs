using JWT_Authentication.Models;
using Microsoft.AspNetCore.Identity.Data;

namespace JWT_Authentication.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Register(User u)
        {
            _context.Users.Add(u);
            _context.SaveChanges();
        }

        public User Login(string user, string pswd)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == user && u.Password == pswd);
        }

        public bool UserExist(string username)
        {
            return _context.Users.Any(u => u.UserName == username);
        }

       
    }
}
