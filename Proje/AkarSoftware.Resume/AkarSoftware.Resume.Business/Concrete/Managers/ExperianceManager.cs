using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.ExperianceDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ExperianceManager: BaseManager,  IExperianceService
    {
        public ExperianceManager(IUnitOfWork uow, IMapper mapper) :base(mapper, uow)
        {
            
        }
        public async Task<IDataResult<List<ExperianceListDto>>> GetExperianceActive()
        {
            var repository = _UnitOfWork.GetGenericRepository<Experiance>();
            var result = await repository.GetAllAsync(x => x.IsActive == true, OrderByProperty: x => x.StartDate, order: OrderByEnum.Descanding);
            if (result == null || result.Count == 0)
                return new NotFoundResult<List<ExperianceListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<ExperianceListDto>>(result);

            if (Dto == null)
                return new MappingError<List<ExperianceListDto>>(ProcessResult.MappingError);

            return new DataResult<List<ExperianceListDto>>(Dto, ResultStatus.Success);
        }
    }
}
