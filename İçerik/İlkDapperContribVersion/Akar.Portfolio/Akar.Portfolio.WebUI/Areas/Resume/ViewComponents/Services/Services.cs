using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Services
{
    public class Services : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_ServicesViewComponents");
        }
    }
}
