using AkarSoftware.Resume.Dtos.BadgetDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.Badget
{
    public class BadgeUpdateValidationRules : AbstractValidator<BadgetUpdateDto>
    {
        public BadgeUpdateValidationRules()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Rozet ismi boş geçilemez");
        }
    }
}
