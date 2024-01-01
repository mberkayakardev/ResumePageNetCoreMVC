using AkarSoftware.Resume.Dtos.AppUserDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.AppUser
{
    public class LoginUserDtoValidationRules : AbstractValidator<LoginUserDto>
    {
        public LoginUserDtoValidationRules()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Kullanıcı adı boş olamaz");
        }
    }
}
