using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Portfolio
{
    public class Portfolio : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_PortfolioViewComponents");
        }
    }
}
