using Akar.Portfolio.Dtos.Concrete.IntroduceDtos;
using FluentValidation;

namespace Akar.Portfolio.Managers.Concrete.ValidatonRules.Introduce
{
    public class DeleteIntroduceRules : AbstractValidator<DeleteIntroduceDto>
    {
        public DeleteIntroduceRules()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Geçerli bir id bilgisi giriniz ");

        }

    }
}
