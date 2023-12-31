using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.BadgetDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class BadgeManager : BaseManager, IBadgeService
    {
        public BadgeManager(IUnitOfWork UnitOfWork, IMapper mapper) : base(mapper, UnitOfWork)
        {
          
        }
        public async Task<IDataResult<List<BadgetListDto>>> GetBadgedActive()
        {
            var repository = _UnitOfWork.GetGenericRepository<Badget>();
            var result = await repository.GetAllAsync(x => x.IsActive == true);
            if (result == null || result.Count == 0)
                return new NotFoundResult<List<BadgetListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<BadgetListDto>>(result);

            if (Dto == null)
                return new MappingError<List<BadgetListDto>>(ProcessResult.MappingError);

            return new DataResult<List<BadgetListDto>>(Dto, ResultStatus.Success);
        }
    }
}
