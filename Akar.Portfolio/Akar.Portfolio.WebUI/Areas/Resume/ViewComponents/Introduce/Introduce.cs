using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Introduce
{
    public class Introduce : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_IntroduceViewComponents");
        }
    }
}
