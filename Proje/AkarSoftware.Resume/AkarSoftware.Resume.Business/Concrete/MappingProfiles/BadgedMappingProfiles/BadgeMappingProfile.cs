using AkarSoftware.Resume.Dtos.BadgetDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.BadgedMappingProfiles
{
    public class BadgeMappingProfile : Profile
    {
        public BadgeMappingProfile()
        {
            CreateMap<Badget, BadgetListDto>().ReverseMap();
            CreateMap<Badget, BadgetUpdateDto>().ReverseMap();
            CreateMap<Badget, BadgetCreateDto>().ReverseMap();

        }

    }
}
