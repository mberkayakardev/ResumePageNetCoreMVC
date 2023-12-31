using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
	public class ProjectController : Controller
	{
		[Route("/projects")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
