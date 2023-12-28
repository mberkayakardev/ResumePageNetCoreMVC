using Akar.Portfolio.Managers.Abstract;
using Akar.Portfolio.WebUI.Areas.Resume.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.ProfileCard
{
    public class ProfileCard : ViewComponent
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaService _socialMediaService;
        public ProfileCard(IAppUserService appUserService, ISocialMediaService socialMediaService)
        {
            _appUserService = appUserService;   
            _socialMediaService = socialMediaService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var UserProfile = await _appUserService.GetAsync();
            var SocailMedias  = await _socialMediaService.GetListAsync(x=> x.IsActive == true);
            var resultModel = new AppUserAndSocailMediaViewModel { AppuserDto = UserProfile.Data, SocialMedias = SocailMedias.Data };
            return View("_ProfileCardViewComponents", resultModel);
        }
    }
}
