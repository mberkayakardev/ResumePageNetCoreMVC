using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
	public class ProgressBarSkills : BaseEntity
    {
        public string SkillName { get; set; }
        public int ProgressBarValue { get; set; }
        public int ProgressBarSkilssMasterId { get; set; }

        #region Navigation Property
        public ProgressBarSkilssMaster progressBarSkilssMaster { get; set; }
        #endregion

    }
}
