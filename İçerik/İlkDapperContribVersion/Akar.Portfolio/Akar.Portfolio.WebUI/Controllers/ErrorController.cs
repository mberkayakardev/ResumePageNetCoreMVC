using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

namespace Akar.Portfolio.WebUI.Controllers
{
    public class ErrorController : Controller
    {

        /// <summary>
        /// Global Hata Yakalayıcı 
        /// </summary>
        public IActionResult GetErrors() 
        { 
            return View(); 
        }

        /// <summary>
        ///  Not Found sayfası
        /// </summary>
        public IActionResult Status(int code)
        {
            return View(code);
        }
    }
}
