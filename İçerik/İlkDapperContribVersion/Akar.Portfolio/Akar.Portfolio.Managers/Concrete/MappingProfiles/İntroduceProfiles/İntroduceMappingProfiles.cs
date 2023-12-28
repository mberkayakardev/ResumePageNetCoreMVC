using Akar.Portfolio.Dtos.Concrete.IntroduceDtos;
using Akar.Portfolio.Entities.Concrete;
using AutoMapper;

namespace Akar.Portfolio.Managers.Concrete.MappingProfiles.İntroduceProfiles
{
    public class İntroduceMappingProfiles : Profile
    {
        public İntroduceMappingProfiles()
        {
            CreateMap<Introduce, ListIntroduceDto>().ReverseMap();
            CreateMap<Introduce, AddIntroduceDto>().ReverseMap();
            CreateMap<Introduce, UpdateIntroduceDto>().ReverseMap();
            CreateMap<Introduce, DeleteIntroduceDto>().ReverseMap();



        }
    }
}
