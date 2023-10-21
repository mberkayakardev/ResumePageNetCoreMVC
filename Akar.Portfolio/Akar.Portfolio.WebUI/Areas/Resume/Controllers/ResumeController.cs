using Akar.Portfolio.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Areas.Resume.Controllers
{
    [Area("Resume")]
    public class ResumeController : Controller
    {
        private readonly IComponentService _componentService;
        public ResumeController(IComponentService componentService)
        {
            _componentService = componentService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _componentService.GetListAsync(x=> x.IsActive == true );
            return View(result.Data);
        }
    }
}
