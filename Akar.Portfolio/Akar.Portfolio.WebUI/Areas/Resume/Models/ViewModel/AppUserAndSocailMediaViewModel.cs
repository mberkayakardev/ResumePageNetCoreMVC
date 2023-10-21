using Akar.Portfolio.Dtos.Concrete.AppUser;
using Akar.Portfolio.Dtos.Concrete.SocialMedia;

namespace Akar.Portfolio.WebUI.Areas.Resume.Models.ViewModel
{
    public class AppUserAndSocailMediaViewModel
    {
        public ListAppUserDto AppuserDto { get; set; }
        public IEnumerable<ListSocialMediaDto> SocialMedias { get; set; }

    }
}
