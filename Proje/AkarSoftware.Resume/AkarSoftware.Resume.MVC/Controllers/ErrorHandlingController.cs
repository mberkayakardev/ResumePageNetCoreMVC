using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Controllers
{
    public class ErrorHandlingController : Controller
    {
        [Route("/exception")]
        public IActionResult ExceptionHandling()
        {
            return View("500");
        }

        [Route("/Error/{statusCode}")]
        public IActionResult Errors(int statusCode)
        {
            if (statusCode == 404)
                return View("404");

            return View("500");
        }
    }
}
