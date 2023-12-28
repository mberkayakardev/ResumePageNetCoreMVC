using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.Dtos.Concrete.AppUser;
using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Entities.Concrete;
using Akar.Portfolio.Managers.Abstract;
using AutoMapper;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.Managers
{
    public class AppUserManager : GenericManager<AppUser, AddAppUserDto, UpdateAppUserDto, DeleteAppUserDto, ListAppUserDto> , IAppUserService
    {
        public AppUserManager(IMapper mapper, IValidator<AddAppUserDto> createValidator, IValidator<UpdateAppUserDto> updateValidator, IValidator<DeleteAppUserDto> deleteValidator, IUnitOfWork unitOfWork) : base(mapper, createValidator, updateValidator, deleteValidator, unitOfWork)
        {
            
        }
    }
}
