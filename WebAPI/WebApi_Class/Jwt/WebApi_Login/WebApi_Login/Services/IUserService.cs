using WebApi_Login.DTOs;

namespace WebApi_Login.Services
{
    public interface IUserService
    {
        string Register(UserRegisterDto userDto);
        string Login(UserLoginDto loginDto);
    }
}
