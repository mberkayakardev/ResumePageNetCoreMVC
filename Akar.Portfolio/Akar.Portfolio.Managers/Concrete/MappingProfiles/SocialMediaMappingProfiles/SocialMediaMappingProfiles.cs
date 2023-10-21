using Akar.Portfolio.Dtos.Concrete.SocialMedia;
using Akar.Portfolio.Entities.Concrete;
using AutoMapper;

namespace Akar.Portfolio.Managers.Concrete.MappingProfiles.SocialMediaMappingProfiles
{
    public class SocialMediaMappingProfiles : Profile
    {
        public SocialMediaMappingProfiles()
        {
            CreateMap<AddSocialMediaDto, SocialMedias>().ReverseMap();
            CreateMap<DeleteSocialMediaDto, SocialMedias>().ReverseMap();
            CreateMap<ListSocialMediaDto, SocialMedias>().ReverseMap();
            CreateMap<UpdateSocialMediaDto, SocialMedias>().ReverseMap();

        }
    }
}
