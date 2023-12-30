using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Landing")]
	public class ResumeController: Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
