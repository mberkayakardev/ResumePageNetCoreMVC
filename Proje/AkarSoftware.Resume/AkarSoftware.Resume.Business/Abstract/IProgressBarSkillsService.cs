using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IProgressBarSkillsService
    {
        Task<IDataResult<List<ProgressBarSkillsListDto>>> GetActiveProgressbarSkills();
        Task<IDataResult<List<ProgressBarSkillsListDto>>> GetProgressbarSkillsWithDeleted();
        Task<IDataResult<ProgressBarSkillsUpdateDto>> GetById(int id);
        Task<IResult> Update(ProgressBarSkillsUpdateDto dto);
        Task<IResult> Delete(int id);
        Task<IResult> Create(ProgressBarSkillsCreateDto dto);



    }
}
