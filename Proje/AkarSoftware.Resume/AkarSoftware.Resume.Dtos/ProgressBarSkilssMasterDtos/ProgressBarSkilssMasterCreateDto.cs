using AkarSoftware.Resume.Core.Dtos.Abstract;
using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Dtos.ProgressBarSkilssMasterDtos
{
    public class ProgressBarSkilssMasterCreateDto : IDto
    {
        public string SkillName { get; set; }
        public int SkillOrder { get; set; }
    }
}
