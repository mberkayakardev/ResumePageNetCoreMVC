using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.TechnologiesDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class TechnologiesManager: BaseManager, ITechnologiesService
	{
        public TechnologiesManager(IUnitOfWork uow, IMapper mapper) : base(mapper, uow)
        {
            
        }
        public async Task<IDataResult<List<TechnologiesListDto>>> GetTechnologiesForPersonelCard()
		{
			var repository = _UnitOfWork.GetGenericRepository<Technologies>();
			var result = await repository.GetAllAsync(x => x.IsActive == true, OrderByProperty: (x =>x.IsActive == true));
			if (result == null)
				return new NotFoundResult<List<TechnologiesListDto>>(ProcessResult.NotFound);

			var Dto = _Mapper.Map<List<TechnologiesListDto>>(result);

			if (Dto == null)
				return new MappingError<List<TechnologiesListDto>>(ProcessResult.MappingError);

			return new DataResult<List<TechnologiesListDto>>(Dto, ResultStatus.Success);

		}
	}
}
