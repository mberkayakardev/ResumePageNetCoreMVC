using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
