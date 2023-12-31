using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.ExperianceDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IExperianceService
    {
        public Task<IDataResult<List<ExperianceListDto>>> GetExperianceActive();
    }
}
