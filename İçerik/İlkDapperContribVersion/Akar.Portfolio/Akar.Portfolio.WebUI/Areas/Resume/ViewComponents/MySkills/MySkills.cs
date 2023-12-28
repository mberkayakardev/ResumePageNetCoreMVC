using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.ViewComponents.MySkills
{
    public class MySkills : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_MySkillsViewComponents");
        }
    }
}
