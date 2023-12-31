using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.TechnologiesDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
	public class TeknolojilerViewComponent : ViewComponent
	{
		private readonly ITechnologiesService technologiesService;

		public TeknolojilerViewComponent(ITechnologiesService technologiesService)
		{
			this.technologiesService = technologiesService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var result = await technologiesService.GetTechnologiesForPersonelCard();
			return this.ReturnViewForComponent<List<TechnologiesListDto>>(result, "default", "teknolojiler");
		}
	}
}
