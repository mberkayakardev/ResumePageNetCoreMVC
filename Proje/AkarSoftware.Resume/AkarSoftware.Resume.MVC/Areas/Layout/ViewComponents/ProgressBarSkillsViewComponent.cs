using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.MVC.Extentions.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace AkarSoftware.Resume.MVC.Areas.Layout.ViewComponents
{
    public class ProgressBarSkillsViewComponent : ViewComponent
    {
        private readonly IProgressBarSkillsService service;
        public ProgressBarSkillsViewComponent(IProgressBarSkillsService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await service.GetActiveProgressbarSkills();
            return this.ReturnViewForComponent<List<ProgressBarSkillsListDto>>(result, "default", "Yetenekler İlerleme Yüzdesi");
        }
    }
}
