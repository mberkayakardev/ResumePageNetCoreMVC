using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.SocialMediasDto;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
	public class SocialMediasPersonelCardViewComponent : ViewComponent
	{
		private readonly ISocialMediaService mediaService;
		public SocialMediasPersonelCardViewComponent(ISocialMediaService mediaService)
		{
			this.mediaService = mediaService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var model = await mediaService.GetSocialMediasActive();
			return this.ReturnViewForComponent<List<SocialMediaListDto>>(model, "default", "Sosyal Medya ikonları");
		}
	}
}
