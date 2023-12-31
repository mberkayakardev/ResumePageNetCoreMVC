using AkarSoftware.Resume.Dtos.AboutMeDto;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.AboutMeMappingProfile
{
	public class AboutMeMappingProfile : Profile
	{
        public AboutMeMappingProfile()
        {
            CreateMap<AboutMeListDto, AboutMe>().ReverseMap();
			CreateMap<AboutMeUpdateDto, AboutMe>().ReverseMap();
			CreateMap<AboutMeCreateDto, AboutMe>().ReverseMap();

		}
	}
}
