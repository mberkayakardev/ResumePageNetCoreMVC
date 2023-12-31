using AkarSoftware.Resume.Dtos.AbilityDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;

namespace AkarSoftware.Resume.Business.Concrete.MappingProfiles.AbilityMappingProfiles
{

	public class AbilityMappingProfiles : Profile
	{
        public AbilityMappingProfiles()
        {
            CreateMap<Ability, AbilityCreateDto>().ReverseMap();
			CreateMap<Ability, AbilityListDto>().ReverseMap();
			CreateMap<Ability, AbilityUpdateDto>().ReverseMap();

		}
	}
}
