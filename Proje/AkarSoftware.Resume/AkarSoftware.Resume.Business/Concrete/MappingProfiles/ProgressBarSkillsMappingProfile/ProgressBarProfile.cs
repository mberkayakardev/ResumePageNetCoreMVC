using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.ProgressBarSkillsMappingProfile
{
    public class ProgressBarProfile :Profile
    {
        public ProgressBarProfile()
        {
            CreateMap<ProgressBarSkills, ProgressBarSkillsCreateDto>().ReverseMap();
            CreateMap<ProgressBarSkills, ProgressBarSkillsUpdateDto>().ReverseMap();
            CreateMap<ProgressBarSkills, ProgressBarSkillsListDto>().ReverseMap();
        }
    }
}
