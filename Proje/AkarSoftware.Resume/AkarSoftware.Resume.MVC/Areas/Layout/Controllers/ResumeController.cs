using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
	public class ResumeController: Controller
	{
		[Route("/resume")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
