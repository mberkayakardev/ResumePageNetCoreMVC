using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IProgressBarSkillsService
    {
        Task<IDataResult<List<ProgressBarSkillsListDto>>> GetActiveProgressbarSkills();
    }
}
