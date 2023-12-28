using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Resume
{
    public class Education : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_EducationViewComponents");
        }
    }
}
