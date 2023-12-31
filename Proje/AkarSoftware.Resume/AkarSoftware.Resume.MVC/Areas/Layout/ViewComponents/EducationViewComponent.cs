using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        private readonly IEducationService _educationService;
        public EducationViewComponent(IEducationService educationService)
        {
            _educationService = educationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _educationService.GetEducationsActive();
            return this.ReturnViewForComponent<List<EducationListDto>>(result, "default", "Eğitimler");
        }
    }
}
