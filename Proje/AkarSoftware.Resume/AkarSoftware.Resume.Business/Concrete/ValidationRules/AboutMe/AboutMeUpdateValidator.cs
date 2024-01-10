using AkarSoftware.Resume.Dtos.AboutMeDto;
using FluentValidation;
using Microsoft.Identity.Client;

namespace AkarSoftware.Resume.Business.Concrete.ValidationRules.AboutMe
{
    public class AboutMeUpdateValidator : AbstractValidator<AboutMeUpdateDto>
    {
        public AboutMeUpdateValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş olamaz");

            RuleFor(x => x.IsActive).Must((model, property1) => CheckCondition(model)).WithMessage("Sistemde bir adet aktfi hakkında yazısı olmak zorundadır.");
            RuleFor(x => x.TumAktifKayitlariPasifeAlinsimi).Must((model, property2) => CheckCondition(model)).WithMessage("Sistemde bir adet aktfi hakkında yazısı olmak zorundadır");
            RuleFor(x => x.TumAktifKayitlariPasifeAl).Must((model, property3) => CheckCondition(model)).WithMessage("Sistemde bir adet aktfi hakkında yazısı olmak zorundadır");

        }

        private bool CheckCondition(AboutMeUpdateDto model)
        {
            if (model.IsActive == true && model.TumAktifKayitlariPasifeAl== false && model.TumAktifKayitlariPasifeAlinsimi == true)
            {
                return false; // Hata vermesin
            }
            else if (model.IsActive == model.TumAktifKayitlariPasifeAl == model.TumAktifKayitlariPasifeAlinsimi == false)
            {
                return true;
            }
            return true; // Aksi taktirde hata versin
           
        }


    }
}
