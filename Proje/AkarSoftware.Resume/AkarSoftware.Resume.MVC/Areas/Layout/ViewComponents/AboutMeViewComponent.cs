using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AboutMeDto;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
	public class AboutMeViewComponent : ViewComponent
	{
		private readonly IAboutMeServices _AboutmeService;
		public AboutMeViewComponent(IAboutMeServices aboutmeService)
		{
			_AboutmeService = aboutmeService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var result = await _AboutmeService.GetAboutMeForPersonelCard();
			return this.ReturnViewForComponent<AboutMeListDto>(result, "default", " Hakkımda ");
		}
	}
}
