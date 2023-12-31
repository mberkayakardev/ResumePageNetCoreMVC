using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Landing")]
	public class AccountController : Controller
	{
		[Route("/singin")]
		public IActionResult Index()
		{
			return View();
		}








		[Route("/singout")]
		public IActionResult singout()
		{
			return View();
		}
	}
}
