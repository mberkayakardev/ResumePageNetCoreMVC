using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.MVC.Extentions.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.Controllers
{
	[Area("Layout")]
	public class AccountController : Controller
	{
		private readonly IAppUserService _appUserService;
        public AccountController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        [HttpGet("/singin")]
		public IActionResult Index(string ReturnUrl)
		{
			return View("singin", new LoginUserDto() { ReturnUrl = ReturnUrl});
		}

		[HttpPost]
        public async Task<IActionResult> singin(LoginUserDto dto)
        {
			var result = await _appUserService.LoginService(dto);
			var redirectObject = new RedirectToActionResult("Index", "Home", new {area = "Admin"});
			return this.CostumeRedirectToAction<LoginUserDto>(result, dto, redirectObject, "singin");
        }


        [Route("/singout")]
		public IActionResult singout()
		{
			return View();
		}
	}
}
