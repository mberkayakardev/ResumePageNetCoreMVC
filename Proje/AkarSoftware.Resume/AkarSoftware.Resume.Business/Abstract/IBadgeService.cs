using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.BadgetDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IBadgeService
    {
        public Task<IDataResult<List<BadgetListDto>>> GetBadgedActive();
    }
}
