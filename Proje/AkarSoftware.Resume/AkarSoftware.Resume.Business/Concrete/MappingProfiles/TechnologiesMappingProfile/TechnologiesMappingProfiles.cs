using AkarSoftware.Resume.Dtos.TechnologiesDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.TechnologiesMappingProfile
{
    public class TechnologiesMappingProfiles: Profile
    {
        public TechnologiesMappingProfiles()
        {
            CreateMap<Technologies, TechnologiesListDto>().ReverseMap();
            CreateMap<Technologies, TechnologiesCreateDto>().ReverseMap();
            CreateMap<Technologies, TechnologiesUpdateDto>().ReverseMap();

        }
    }
}
