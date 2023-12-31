using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.Dtos.SocialMediasDto;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class EducationManager : BaseManager, IEducationService
    {
        public EducationManager(IMapper mapper, IUnitOfWork uow) : base(mapper, uow)
        {

        }
        public async Task<IDataResult<List<EducationListDto>>> GetEducationsActive()
        {
            var repository = _UnitOfWork.GetGenericRepository<Education>();
            var result = await repository.GetAllAsync(x => x.IsActive == true, OrderByProperty:x=> x.StartDate , order: OrderByEnum.Ascending);
            if (result == null ||result.Count == 0)
                return new NotFoundResult<List<EducationListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<EducationListDto>>(result);

            if (Dto == null)
                return new MappingError<List<EducationListDto>>(ProcessResult.MappingError);

            return new DataResult<List<EducationListDto>>(Dto, ResultStatus.Success);
        }
    }
}
