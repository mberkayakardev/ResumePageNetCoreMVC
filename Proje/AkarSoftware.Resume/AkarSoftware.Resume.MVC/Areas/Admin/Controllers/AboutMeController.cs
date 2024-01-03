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
    }
}
