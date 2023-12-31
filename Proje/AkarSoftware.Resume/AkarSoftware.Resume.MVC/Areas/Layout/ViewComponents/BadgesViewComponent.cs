using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.BadgetDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents.Badge
{
    public class BadgesViewComponent : ViewComponent
    {
        private readonly IBadgeService service;
        public BadgesViewComponent(IBadgeService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await service.GetBadgedActive();
            return this.ReturnViewForComponent(result, "default", "Yetenek Rozetleri");
        }
    }
}
