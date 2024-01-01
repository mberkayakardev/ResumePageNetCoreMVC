using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ProjectDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _ProjectService;
        public ProjectController(IProjectService projectService)
        {
            _ProjectService = projectService;
        }

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
            var result = await _ProjectService.CreateNewProject(dto);
            return this.CostumeRedirectToAction<ProjectCreateDto>(result, dto, new RedirectToActionResult("Index", "Home", new { Area = "Admin" }), "Admin/Project/CreateProject");
		}



	}
}
