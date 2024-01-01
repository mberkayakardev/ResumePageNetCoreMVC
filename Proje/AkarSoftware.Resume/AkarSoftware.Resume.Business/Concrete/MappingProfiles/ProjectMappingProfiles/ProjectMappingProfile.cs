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
			CreateMap<Project, ProjectCreateDto>().ReverseMap();
            CreateMap<Project, ProjectUpdateDto>().ReverseMap();
		}
	}
}
