using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Entities.Concrete;
using AutoMapper;

namespace Akar.Portfolio.Managers.Concrete.MappingProfiles.ComponentProfiles
{
    public class ComponentMappingProfiles : Profile
    {
        public ComponentMappingProfiles()
        {
            CreateMap<AddComponentDto, Component>().ReverseMap();
            CreateMap<UpdateComponentDto, Component>().ReverseMap();
            CreateMap<ListComponentDto, Component>().ReverseMap();
            CreateMap<DeleteComponentDto, Component>().ReverseMap();



        }
    }
}
