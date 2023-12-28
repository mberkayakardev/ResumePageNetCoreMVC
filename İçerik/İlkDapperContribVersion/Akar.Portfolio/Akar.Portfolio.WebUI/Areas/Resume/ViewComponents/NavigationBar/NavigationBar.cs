using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.NavigationBar
{
    public class NavigationBar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_NavigationBarViewComponents");
        }
    }
}
