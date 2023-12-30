using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.SocialMediasDto;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
	public class SocialMediaManager : BaseManager, ISocialMediaService
	{
		public SocialMediaManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
		{

		}

		public async Task<IDataResult<List<SocialMediaListDto>>> GetSocialMediasActive()
		{
			var repository = _UnitOfWork.GetGenericRepository<SocailMedias>();
			var result = await repository.GetAllAsync(x => x.IsActive == true);
			if (result == null)
				return new NotFoundResult<List<SocialMediaListDto>>(ProcessResult.NotFound);

			var Dto = _Mapper.Map<List<SocialMediaListDto>>(result);

			if (Dto == null)
				return new MappingError<List<SocialMediaListDto>>(ProcessResult.MappingError);

			return new DataResult<List<SocialMediaListDto>>(Dto, ResultStatus.Success);

		}
	}
}
