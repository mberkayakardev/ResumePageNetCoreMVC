using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
	public class PersonelCardViewComponent : ViewComponent
	{
		private readonly IAppUserService _AppUserService;
		public PersonelCardViewComponent(IAppUserService appUserService)
		{
			_AppUserService = appUserService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var result = await _AppUserService.GetUserForPersonelCard();
			return this.ReturnViewForComponent<AppUserListDto>(result, "default", "Personel Kart");

		}
	}
}
