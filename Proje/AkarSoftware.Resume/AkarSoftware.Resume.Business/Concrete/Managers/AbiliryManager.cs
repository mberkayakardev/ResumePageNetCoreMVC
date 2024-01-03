using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.AbilityDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
	public class AbilityManager : BaseManager, IAbiliryService
	{
        
        public AbilityManager(IUnitOfWork unitOfWork, IMapper mapper) : base(mapper, unitOfWork)
        {
            
        }

        public async Task<IDataResult<AbilityListDto>> GetAbilitiesForId(int id)
        {
            var repository = _UnitOfWork.AbilityRepository;
            var result = await repository.GetByIdWithOrdersNumber(id);
            if (result == null)
                return new NotFoundResult<AbilityListDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<AbilityListDto>(result);

            if (Dto == null)
                return new MappingError<AbilityListDto>(ProcessResult.MappingError);

            return new DataResult<AbilityListDto>(Dto, ResultStatus.Success);
        }

        public async Task<IDataResult<List<AbilityListDto>>> GetAbilitiesForPersonelCard()
		{
			var repository = _UnitOfWork.GetGenericRepository<Ability>();
			var result = await repository.GetAllAsync(x => x.IsActive == true, OrderByProperty: (x=> x.OrderNumber) , order: OrderByEnum.Ascending);
			if (result == null)
				return new NotFoundResult<List<AbilityListDto>>(ProcessResult.NotFound);

			var Dto = _Mapper.Map<List<AbilityListDto>>(result);

			if (Dto == null)
				return new MappingError<List<AbilityListDto>>(ProcessResult.MappingError);

			return new DataResult<List<AbilityListDto>>(Dto, ResultStatus.Success);
		}

        public async Task<IDataResult<List<AbilityListDto>>> GetAllAbilitiesWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<Ability>();
            var result = await repository.GetAllAsync();
            if (result == null)
                return new NotFoundResult<List<AbilityListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<AbilityListDto>>(result);

            if (Dto == null)
                return new MappingError<List<AbilityListDto>>(ProcessResult.MappingError);

            return new DataResult<List<AbilityListDto>>(Dto, ResultStatus.Success);
        }
    }
}
