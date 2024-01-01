using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Controllers
{
    public class ErrorHandlingController : Controller
    {
        [Route("/exception")]
        public IActionResult ExceptionHandling()
        {
            return View();
        }

		[Route("/Error/{statusCode}")]
		public IActionResult Errors(int statusCode)
        {
            return View("404");
        }
    }
}
