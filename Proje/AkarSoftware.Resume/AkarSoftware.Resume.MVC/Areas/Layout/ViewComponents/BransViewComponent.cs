using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AbilityDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
	public class BransViewComponent : ViewComponent
	{
		private readonly IAbiliryService _AbiliryService;
		public BransViewComponent(IAbiliryService abiliryService)
		{
			_AbiliryService = abiliryService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var result = await _AbiliryService.GetAbilitiesForPersonelCard();
			return this.ReturnViewForComponent<List<AbilityListDto>>(result, "default", "Branşlar");
		}
	}
}
