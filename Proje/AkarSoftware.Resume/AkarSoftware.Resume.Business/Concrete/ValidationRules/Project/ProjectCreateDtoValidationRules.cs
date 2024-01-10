using AkarSoftware.Resume.Dtos.ProjectDtos;
using FluentValidation;
using System.Data;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.Project
{
    public class ProjectCreateDtoValidationRules : AbstractValidator<ProjectCreateDto>
    {
        public ProjectCreateDtoValidationRules()
        {
            RuleFor(x => x.ProjectCreateDate).NotEmpty().NotNull().WithMessage("Lütfen projenize bir oluşturma tarihi giriniz.");
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Lütfen projen adı giriniz.");
            RuleFor(x => x.Description).NotEmpty().NotNull().WithMessage("Lütfen projenize bir alan giriniz.");
            RuleFor(x => x.ShortDescription).NotEmpty().NotNull().WithMessage("Lütfen projenize Kısa Açıklama giriniz.");
            RuleFor(x => x.ProjectImage).NotNull().WithMessage("Lütfen Projenize kapak resmi seçiniz");
            RuleFor(x => x.ProjectType).Must(x => x == 1 || x == 2).WithMessage("Proje tipi Belirtiniz");






        }
    }
}
