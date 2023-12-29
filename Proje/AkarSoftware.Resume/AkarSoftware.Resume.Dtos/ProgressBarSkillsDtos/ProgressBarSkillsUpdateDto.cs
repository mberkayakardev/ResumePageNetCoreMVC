using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos
{
    public class ProgressBarSkillsUpdateDto : BaseUpdateDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string SkillName { get; set; }
        public int ProgressBarValue { get; set; }
        public int ProgressBarSkilssMasterId { get; set; }
    }
}
