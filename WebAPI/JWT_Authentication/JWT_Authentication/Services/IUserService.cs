using JWT_Authentication.DTO;

namespace JWT_Authentication.Services
{
    public interface IUserService
    {
        string Register(UserRegisterDto dto);

        string Login(UserLoginDto dto);
    }
}
