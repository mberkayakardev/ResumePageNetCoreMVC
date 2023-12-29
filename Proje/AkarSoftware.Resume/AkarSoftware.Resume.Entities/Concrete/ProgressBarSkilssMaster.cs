using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
    public class ProgressBarSkilssMaster : BaseEntity
    {
        public string SkillName { get; set; }
        public int SkillOrder { get; set; }
        #region Navigation Property
        public List<ProgressBarSkills> Skills { get; set; }
        #endregion

    }
}
