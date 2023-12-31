using AkarSoftware.Resume.Dtos.ExperianceDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.ExperianceMappingProfile
{
    public class ExperianceMappingProfiles : Profile
    {
        public ExperianceMappingProfiles()
        {
            CreateMap<Experiance, ExperianceListDto>().ReverseMap();
            CreateMap<Experiance, ExperianceCreateDto>().ReverseMap();
            CreateMap<Experiance, ExperianceUpdateDto>().ReverseMap();
        }
    }
}
