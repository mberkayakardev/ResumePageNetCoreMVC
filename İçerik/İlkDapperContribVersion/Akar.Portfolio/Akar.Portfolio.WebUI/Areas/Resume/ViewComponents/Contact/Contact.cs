using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.Contact
{
    public class Contact : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_ContactViewComponents");
        }
    }
}
