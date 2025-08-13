using JWT_Authentication.DTO;
using JWT_Authentication.Models;

namespace JWT_Authentication.Repository
{
    public interface IUserRepository
    {
        void Register(User u);

        User Login(string u, string p);

        bool UserExist(string username);
    }
}
