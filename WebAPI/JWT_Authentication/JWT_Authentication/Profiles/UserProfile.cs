using AutoMapper;
using JWT_Authentication.DTO;
using JWT_Authentication.Models;
using System.Runtime.InteropServices;

namespace JWT_Authentication.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile() 
        {
            CreateMap<UserRegisterDto, User>();
        }
    }
}
