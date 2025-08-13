using AutoMapper;
using Session_Userdto_LoginRegister.Models;

namespace Session_Userdto_LoginRegister.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, User>();
        }
    }
}
