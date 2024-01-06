using AkarSoftware.Resume.Business.Concrete.ComplexTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AppSettingsOptions _options;
        public HomeController(IOptions<AppSettingsOptions> options)
        {
            _options = options.Value;
        }

        [Route("/admin/dashboard")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/mainterence")]
        [HttpGet]
        public JsonResult MainterenceModeInformation()
        {
            Thread.Sleep(10000);
            return Json(_options.MainterenceMode.ToString());

        }

        [HttpPost]
        [Route("/mainterenceEnable")]

        public JsonResult OpenMainterenceMode()
        {
            if (_options.MainterenceMode)
            {
                _options.MainterenceMode = false;
            }
            return Json("Mainterence mode açıldı");
        }

        [HttpPost]
        [Route("/mainterenceDisable")]

        public JsonResult CloseMainterenceMode()
        {
            if (!_options.MainterenceMode)
            {
                _options.MainterenceMode=true;
            }
            return Json("Mainterence mode Kapatıldı ");
        }
    }
}
