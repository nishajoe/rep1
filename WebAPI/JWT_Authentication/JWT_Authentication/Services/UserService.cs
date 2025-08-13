using AutoMapper;
using JWT_Authentication.DTO;
using JWT_Authentication.Models;
using JWT_Authentication.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Authentication.Services
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;

        public UserService(IUserRepository repo, IMapper mapper, IConfiguration config)
        {
            _repo = repo;
            _mapper = mapper;
            _config = config;
        }

        public string Register(UserRegisterDto dto)
        {
            if (_repo.UserExist(dto.UserName))
                return "Username already exist!";
            var user = _mapper.Map<User>(dto);
            _repo.Register(user);
            return "Registration Successful";
        }

        public string Login(UserLoginDto dto)
        {
            var user=_repo.Login(dto.UserName,dto.Password);
            if (user == null)
                return "Invalid username or password";

            //Generate token
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,user.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
