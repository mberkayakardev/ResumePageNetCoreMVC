using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ExperianceProgressBarController : Controller
    {
        private readonly IProgressBarSkillsService _progressBarSkillsService;

        public ExperianceProgressBarController(IProgressBarSkillsService progressBarSkillsService)
        {
            _progressBarSkillsService = progressBarSkillsService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _progressBarSkillsService.GetProgressbarSkillsWithDeleted();
            return this.CostumeView<List<ProgressBarSkillsListDto>>(result, "index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _progressBarSkillsService.GetById(id);
            return this.CostumeView<ProgressBarSkillsUpdateDto>(result, "Update");
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProgressBarSkillsUpdateDto dto)
        {
            var result = await _progressBarSkillsService.Update(dto);
            return this.CostumeRedirectToAction<ProgressBarSkillsUpdateDto>(result, dto, RedirectToAction("Index", "Home"),"Update");
        }

        public IActionResult Create()
        {
            return View(new ProgressBarSkillsCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProgressBarSkillsCreateDto dto)
        {
            var result = await _progressBarSkillsService.Create(dto);
            return this.CostumeRedirectToAction<ProgressBarSkillsCreateDto>(result, dto, RedirectToAction("Index", "Home"), "Create");

        }
    }
}
