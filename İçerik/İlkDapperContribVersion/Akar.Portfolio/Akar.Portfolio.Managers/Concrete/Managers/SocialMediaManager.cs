using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Dtos.Concrete.SocialMedia;
using Akar.Portfolio.Entities.Concrete;
using Akar.Portfolio.Managers.Abstract;
using AutoMapper;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.Managers
{
    public class SocialMediaManager  : GenericManager<SocialMedias, AddSocialMediaDto, UpdateSocialMediaDto, DeleteSocialMediaDto, ListSocialMediaDto> , ISocialMediaService
    {
        public SocialMediaManager(IMapper mapper, IValidator<AddSocialMediaDto> createValidator, IValidator<UpdateSocialMediaDto> updateValidator, IValidator<DeleteSocialMediaDto> deleteValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, deleteValidator, unitOfWork)
        {
            
        }

    }
}
