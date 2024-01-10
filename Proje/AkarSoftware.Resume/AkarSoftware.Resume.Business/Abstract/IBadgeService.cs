using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.BadgetDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IBadgeService
    {
        public Task<IDataResult<List<BadgetListDto>>> GetBadgedActive();
        public Task<IDataResult<List<BadgetListDto>>> GetAllBadgedWithDeleted();
        public Task<IDataResult<BadgetUpdateDto>> GetById(int id);
        public Task<IResult> Update(BadgetUpdateDto Dto);
        public Task<IResult> Add(BadgetCreateDto Dto);
        public Task<IResult> Delete(int id);



    }
}
