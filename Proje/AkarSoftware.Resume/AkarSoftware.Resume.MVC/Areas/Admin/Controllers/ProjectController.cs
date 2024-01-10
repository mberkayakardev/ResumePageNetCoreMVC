using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ProjectDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _ProjectService;
        public ProjectController(IProjectService projectService)
        {
            _ProjectService = projectService;
        }
        
        
        public async Task<IActionResult> Index()
        {
            var result  = await _ProjectService.GetAllProjectsWithDeleted();
            return this.CostumeView<List<ProjectListDto>>(result, "Index");
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }
		
        [HttpPost]
		public async Task<IActionResult> CreateProject(ProjectCreateDto dto)
		{
            var result = await _ProjectService.CreateNewProject(dto);
            return this.CostumeRedirectToAction<ProjectCreateDto>(result, dto, new RedirectToActionResult("Index", "Home", new { Area = "Admin" }), "CreateProject");
		}

        [HttpGet]
        public async Task<IActionResult> UpdateProject(int id)
        {
            var result = await _ProjectService.GetProjectForUpdateById(id);
            return this.CostumeView<ProjectUpdateDto>(result, "UpdateProject");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProject(ProjectUpdateDto dto)
        {
            var result = await _ProjectService.UpdateProject(dto);
            return this.CostumeRedirectToAction<ProjectUpdateDto>(result, dto,  new RedirectToActionResult("Index", "Home", new { Area = "Admin" }), "UpdateProject");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var result = await _ProjectService.DeleteProject(id);
            return RedirectToAction("Index", "Home");
        }


    }
}
