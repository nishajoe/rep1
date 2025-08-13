using AutoMapper;
using Userdto_LoginRegister.Models;

namespace Userdto_LoginRegister.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Userdto, User>();
        }
    }
}
