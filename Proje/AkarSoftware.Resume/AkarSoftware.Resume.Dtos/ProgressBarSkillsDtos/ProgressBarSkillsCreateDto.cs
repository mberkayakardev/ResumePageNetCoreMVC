using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos
{
    public class ProgressBarSkillsCreateDto : IDto
    {
        public string SkillName { get; set; }
        public int ProgressBarValue { get; set; }
        public int ProgressBarSkilssMasterId { get; set; }
    }
}
