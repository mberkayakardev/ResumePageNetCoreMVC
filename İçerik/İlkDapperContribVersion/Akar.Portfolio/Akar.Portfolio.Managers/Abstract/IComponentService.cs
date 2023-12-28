using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using AddComponentDto = Akar.Portfolio.Dtos.Concrete.ComponentDtos.AddComponentDto;

namespace Akar.Portfolio.Managers.Abstract
{
    public interface IComponentService : IGenericService<Entities.Concrete.Component, AddComponentDto, UpdateComponentDto, DeleteComponentDto, ListComponentDto>
    {

    }
}
