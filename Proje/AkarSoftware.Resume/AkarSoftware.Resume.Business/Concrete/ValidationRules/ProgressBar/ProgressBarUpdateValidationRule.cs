using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.ProgressBar
{
    public class ProgressBarUpdateValidationRule : AbstractValidator<ProgressBarSkillsUpdateDto>
    {
        public ProgressBarUpdateValidationRule()
        {
            RuleFor(x => x.ProgressBarValue).NotNull().WithMessage("Progressbar değeri boş geçilemez");
            RuleFor(x => x.ProgressBarValue).InclusiveBetween(0,100).WithMessage("Progressbar değeri 0 - 100 aralığında olmalıdır");

        }
    }
}
