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

        [Route("/errors")]
        public IActionResult Errors(int code)
        {
            return View();
        }
    }
}
