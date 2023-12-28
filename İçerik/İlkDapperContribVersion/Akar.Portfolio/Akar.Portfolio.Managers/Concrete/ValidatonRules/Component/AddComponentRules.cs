using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.ValidatonRules.Components
{
    public class AddComponentRules : AbstractValidator<AddComponentDto>
    {
        public AddComponentRules()
        {
            RuleFor(x => x.ComponentName).NotEmpty().WithMessage("Komponent Adı olmadan kayıt gerçekleştirilemez");
            RuleFor(x => x.ComponentProjectName).NotEmpty().WithMessage("Proje komponenti olmadan ilgili kayıt gerçekleştirilemez");
            RuleFor(x => x.OrderNumber).NotEmpty().WithMessage("Sıra numarası olmadan işlem yapılamaz");
            RuleFor(x => x.ComponentDivId).NotNull().WithMessage("Navbarda ilgili alanın gözükebilmesi için bu alan boş geçilemez");
        }

    }
}
