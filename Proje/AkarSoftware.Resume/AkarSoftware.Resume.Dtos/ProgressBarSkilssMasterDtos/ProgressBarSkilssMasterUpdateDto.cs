using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.ProgressBarSkilssMasterDtos
{
    public class ProgressBarSkilssMasterUpdateDto  : BaseUpdateDto
    {
        public string SkillName { get; set; }
        public int SkillOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
