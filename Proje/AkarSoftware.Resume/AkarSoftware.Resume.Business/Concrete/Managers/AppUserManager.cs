using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
	public class AppUserManager : BaseManager,  IAppUserService
	{
        public AppUserManager(IUnitOfWork uow, IMapper mapper) : base(mapper, uow)
        {
            
        }

		public async Task<IDataResult<AppUserListDto>> GetUserForPersonelCard()
		{
			var repository = _UnitOfWork.GetGenericRepository<AppUser>();
			var result = await repository.GetAsync(x=> x.IsActive == true);
			if (result == null)
				return new NotFoundResult<AppUserListDto>(ProcessResult.NotFound);

			var Dto = _Mapper.Map<AppUserListDto>(result);

			if (Dto == null)
				return new MappingError<AppUserListDto>(ProcessResult.MappingError);

			return new DataResult<AppUserListDto>(Dto, ResultStatus.Success);

		}
	}
}
