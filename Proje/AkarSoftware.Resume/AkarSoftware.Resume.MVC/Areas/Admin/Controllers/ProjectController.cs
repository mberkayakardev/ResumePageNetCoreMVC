using AkarSoftware.Resume.Dtos.ProjectDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateProject()
        {
            return View();
        }
		
        [HttpPost]
		public async Task<IActionResult> CreateProject(ProjectCreateDto dto)
		{
			return View();
		}



	}
}
