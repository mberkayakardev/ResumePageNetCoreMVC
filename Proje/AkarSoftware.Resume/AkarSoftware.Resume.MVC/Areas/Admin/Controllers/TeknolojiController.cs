using AkarSoftware.Resume.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class TeknolojiController : Controller
    {
        private readonly ITechnologiesService _technologiesService;
        public TeknolojiController(ITechnologiesService technologiesService)
        {
            _technologiesService = technologiesService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
