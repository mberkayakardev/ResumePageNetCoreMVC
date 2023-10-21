using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Entities.Concrete;
using Akar.Portfolio.Managers.Abstract;
using AutoMapper;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.Managers
{
    public class ComponentManager : GenericManager<Component, AddComponentDto, UpdateComponentDto, DeleteComponentDto, ListComponentDto >, IComponentService
    {
        public ComponentManager(IMapper mapper, IValidator<AddComponentDto> createValidator, IValidator<UpdateComponentDto> updateValidator, IValidator<DeleteComponentDto> deleteValidator, IUnitOfWork unitOfWork) : base (mapper, createValidator, updateValidator, deleteValidator, unitOfWork)
        {
            
        }

    }
}
