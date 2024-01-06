using AkarSoftware.Resume.Dtos.ProjectDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.ProjectMappingProfiles
{
    internal class ProjectMappingProfile : Profile
    {
        public ProjectMappingProfile()
        {
            CreateMap<Project, ProjectListDto>().ReverseMap();
            CreateMap<Project, ProjectCreateDto>().ReverseMap().ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true)); // bu sayede create dto larım her zaman is active = true olarak map olacak 
            CreateMap<Project, ProjectUpdateDto>().ReverseMap().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));

        }
    }
}
