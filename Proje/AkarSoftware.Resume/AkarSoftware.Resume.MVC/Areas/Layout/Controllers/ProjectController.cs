using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ProjectDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
	public class ProjectController : Controller
	{
		private readonly IProjectService projectService;
        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [Route("/projects")]
		public async Task<IActionResult> Index()
		{ 
            var result = await projectService.GetActiveProjects();
			return this.CostumeView<List<ProjectListDto>>(result, "index");
		}

        [Route("/projects/{id}")]
        public async Task<IActionResult> GetByid(int id)
        {
            var result = await projectService.GetProjectById(id);
            return this.CostumeView<ProjectListDto>(result, "detail");
        }
    }
}
