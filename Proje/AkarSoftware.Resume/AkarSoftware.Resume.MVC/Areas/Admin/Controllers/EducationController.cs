using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;
        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }



        public async Task<IActionResult> Index()
        {
            var result = await _educationService.GetEducationsWithDeleted();
            return this.CostumeView<List<EducationListDto>>(result,"index");
        }
    }
}
