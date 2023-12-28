using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.About
{
    public class About : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_AboutViewComponents");

        }
    }
}
