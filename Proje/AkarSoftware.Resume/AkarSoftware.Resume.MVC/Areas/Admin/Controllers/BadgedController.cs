using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.BadgetDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class BadgedController : Controller
    {
        private readonly IBadgeService badgeService;
        public BadgedController(IBadgeService badgeService)
        {
            this.badgeService = badgeService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await badgeService.GetAllBadgedWithDeleted();
            return this.CostumeView<List<BadgetListDto>>(result, "index");
        }

        public async Task<IActionResult> GetById(int id)
        {
            var result = await badgeService.GetById(id);
            return this.CostumeView<BadgetUpdateDto>(result, "Update");
        }

        [HttpPost]
        public async Task<IActionResult> Update(BadgetUpdateDto dto)
        {
            var result = await badgeService.Update(dto);
            return this.CostumeRedirectToAction(result, RedirectToAction("Index"), Url.Action("GetById", dto.Id));
        }

        public async Task<IActionResult> DeleteBadged(int id)
        {
            var result = await badgeService.Delete(id);
            return this.CostumeRedirectToAction(result, RedirectToAction("Index"), Url.Action("DeleteBadged", id));

        }

        public IActionResult Create()
        {
            return View("Create", new BadgetCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(BadgetCreateDto dto)
        {
            var result = await badgeService.Add(dto);
            return this.CostumeRedirectToAction(result, dto, RedirectToAction("Index"), Url.Action("Create"));
        }

    }
}
