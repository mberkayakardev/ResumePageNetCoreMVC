using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Dtos.Concrete.IntroduceDtos;
using Akar.Portfolio.Entities.Concrete;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.ValidatonRules.Components
{
    public class DeleteComponentRules : AbstractValidator<DeleteComponentDto>
    {
        public DeleteComponentRules()
        {
            RuleFor(x=> x.Id).NotNull().NotEmpty().WithMessage("Silinecek component bilgisi için geçerli bir id değeri giriniz");
        }

    }
}
