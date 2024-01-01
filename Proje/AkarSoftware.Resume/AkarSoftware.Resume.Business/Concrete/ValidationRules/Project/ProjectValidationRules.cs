using AkarSoftware.Resume.Dtos.ProjectDtos;
using FluentValidation;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.Project
{
	public class ProjectValidationRules : AbstractValidator<ProjectCreateDto>
	{
		public ProjectValidationRules()
		{
			RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Proje adı zorunludur");
			RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Proje ye açıklama girilmesi zorunludur");
		}
	}
}
