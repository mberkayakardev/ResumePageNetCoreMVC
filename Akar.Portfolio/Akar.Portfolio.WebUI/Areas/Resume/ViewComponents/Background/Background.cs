using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Backround
{
    public class Background : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_BackgroundViewComponents");
        }
    }
}
