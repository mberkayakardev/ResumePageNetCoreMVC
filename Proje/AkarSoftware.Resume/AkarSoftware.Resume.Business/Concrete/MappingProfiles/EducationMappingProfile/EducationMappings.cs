using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.EducationMappingProfile
{
    public class EducationMappings : Profile
    {
        public EducationMappings()
        {
            CreateMap<Education, EducationCreateDto>().ReverseMap();
            CreateMap<Education, EducationListDto>().ReverseMap();
            CreateMap<Education, EducationUpdateDto>().ReverseMap();
        }
    }
}
