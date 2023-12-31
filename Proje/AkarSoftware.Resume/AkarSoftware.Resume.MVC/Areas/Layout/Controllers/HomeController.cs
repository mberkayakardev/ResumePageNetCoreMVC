using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
    public class HomeController : Controller
    {
		[Route("/")]
		public IActionResult Index()
        {
            return View();
        }
        
    }
}
