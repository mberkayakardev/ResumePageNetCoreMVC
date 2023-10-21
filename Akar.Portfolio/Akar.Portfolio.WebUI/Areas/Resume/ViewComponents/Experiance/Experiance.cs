using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Experiance
{
    public class Experiance : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_ExperianceViewComponents");
        } 
    }
}
