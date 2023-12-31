using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ExperianceDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
    public class ExperianceViewComponent : ViewComponent
    {
        private readonly IExperianceService experianceService;
        public ExperianceViewComponent(IExperianceService experianceService)
        {
            this.experianceService = experianceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await experianceService.GetExperianceActive();
            return this.ReturnViewForComponent<List<ExperianceListDto>>(result, "default", "İş deneyimleri ");
        }
    }
}
