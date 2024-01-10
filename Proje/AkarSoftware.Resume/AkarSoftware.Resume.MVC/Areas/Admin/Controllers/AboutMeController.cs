using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AboutMeDto;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AkarSoftware.Resume.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AboutMeController : Controller
    {

        private readonly IAboutMeServices _aboutMe;
        public AboutMeController(IAboutMeServices aboutMe)
        {
            _aboutMe = aboutMe;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _aboutMe.GetAllAboutMeWithDeleted();
            return this.CostumeView<List<AboutMeListDto>>(result, "index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _aboutMe.GetAboutMeWithId(id);
            return this.CostumeView<AboutMeUpdateDto>(result, "Update");
        }

        [HttpPost]
        public async Task<IActionResult> Update(AboutMeUpdateDto dto)
        {
            var result = await _aboutMe.UpdateAboutMe(dto);
            return this.CostumeRedirectToAction<AboutMeUpdateDto>(result, dto, new RedirectToActionResult("Index", "Home", new { Area = "Admin" }), "Admin/AboutMe/Update/"+dto.Id );
        }


        public IActionResult Create()
        {
            return View("Create");
        }



    }
}
