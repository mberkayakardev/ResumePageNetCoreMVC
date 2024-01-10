using AkarSoftware.Resume.Dtos.ProjectDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.Project
{
    public class ProjectUpdateValidationRules : AbstractValidator<ProjectUpdateDto>
    {
        public ProjectUpdateValidationRules()
        {
            RuleFor(x => x.ProjectCreateDate).NotEmpty().NotNull().WithMessage("Lütfen projenize bir oluşturma tarihi giriniz.");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Lütfen projen adı giriniz.");
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Lütfen projenize bir alan giriniz.");
            RuleFor(x => x.ProjectType).Must(x=> x ==1 ||x== 2) .WithMessage("Proje tipi Belirtiniz");
            RuleFor(x => x.ShortDescription).NotEmpty().NotNull().WithMessage("Lütfen projenize Kısa Açıklama giriniz.");
            RuleFor(x => x.ProjectImageURL)
          .NotEmpty()
          .When(x => x.File == null)
          .WithMessage("Lütfen bir image seçiniz. ");

            RuleFor(x => x.File)
                .NotEmpty()
                .When(x => x.ProjectImageURL == null)
                .WithMessage("Lütfen bir image seçiniz.");



        }
    }
}
