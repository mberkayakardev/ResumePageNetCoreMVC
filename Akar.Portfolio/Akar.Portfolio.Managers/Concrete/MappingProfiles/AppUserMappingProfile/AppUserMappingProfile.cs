using Akar.Portfolio.Dtos.Concrete.AppUser;
using Akar.Portfolio.Entities.Concrete;
using AutoMapper;

namespace Akar.Portfolio.Managers.Concrete.MappingProfiles.AppUserMappingProfile
{
    public class AppUserMappingProfile : Profile
    {
        public AppUserMappingProfile()
        {
            CreateMap<AppUser, AddAppUserDto>().ReverseMap();
            CreateMap<AppUser, UpdateAppUserDto>().ReverseMap();
            CreateMap<AppUser, DeleteAppUserDto>().ReverseMap();
            CreateMap<AppUser, ListAppUserDto>().ReverseMap();

        }
    }
}
