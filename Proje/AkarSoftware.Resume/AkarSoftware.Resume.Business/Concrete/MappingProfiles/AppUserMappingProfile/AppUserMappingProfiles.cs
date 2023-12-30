using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.AppUserMappingProfile
{
	public class AppUserMappingProfiles: Profile
	{
        public AppUserMappingProfiles()
        {
            CreateMap<AppUserListDto, AppUser>().ReverseMap();
			CreateMap<AppUserUpdateDto, AppUser>().ReverseMap();
            CreateMap<AppUserCreateDto, AppUser>().ReverseMap();
		}
	}
}
