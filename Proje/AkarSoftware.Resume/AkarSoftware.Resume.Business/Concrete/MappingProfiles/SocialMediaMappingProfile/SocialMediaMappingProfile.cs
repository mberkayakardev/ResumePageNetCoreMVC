using AkarSoftware.Resume.Dtos.SocialMediasDto;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.SocialMediaMappingProfile
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {
            CreateMap<SocialMediaListDto, SocailMedias>().ReverseMap();
            CreateMap<SocialMediaCreateDto, SocailMedias>().ReverseMap();
            CreateMap<SocialMediaUpdateDto, SocailMedias>().ReverseMap();
        }
    }
}
