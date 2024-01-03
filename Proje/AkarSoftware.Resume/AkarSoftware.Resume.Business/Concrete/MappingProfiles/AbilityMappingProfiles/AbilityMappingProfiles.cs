using AkarSoftware.Resume.DataAccess.ObjectModels;
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


            CreateMap<DataAndOrdersNumber<Ability>, AbilityListDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Data.Id))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Data.IsActive))
                    .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.Data.CreatedDate))
                    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.Data.ModifiedDate))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Data.Description))
                    .ForMember(dest => dest.OrderNumber, opt => opt.MapFrom(src => src.Data.OrderNumber))
                    .ForMember(dest => dest.UrlPath, opt => opt.MapFrom(src => src.Data.UrlPath))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Data.Name))
                    .ForMember(dest => dest.OrderNumbers, opt => opt.MapFrom(src => src.OrdersNumbers));


        }
    }
}
