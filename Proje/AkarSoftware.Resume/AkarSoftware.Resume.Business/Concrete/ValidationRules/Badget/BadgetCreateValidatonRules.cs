using AkarSoftware.Resume.Dtos.BadgetDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.Badget
{
    public class BadgetCreateValidatonRules: AbstractValidator<BadgetCreateDto>
    {
        public BadgetCreateValidatonRules()
        {
            RuleFor(x=> x.Name).NotEmpty().WithName("İsim alanı boş bırakılamaz");
        }
    }
}
