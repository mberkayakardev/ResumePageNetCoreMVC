using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AbilityDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class PlatformController : Controller
    {
        private readonly IAbiliryService _abiliryService;
        public PlatformController(IAbiliryService abiliryService)
        {
            _abiliryService = abiliryService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _abiliryService.GetAllAbilitiesWithDeleted();
            return this.CostumeView<List<AbilityListDto>>(result,"index");
        }
        [HttpGet("/Platform/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _abiliryService.GetAbilitiesForId(id);
            return this.CostumeView<AbilityListDto>(result, "getbyid");
        }
    }
}
