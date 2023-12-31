using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ProgressBarSkillsManager : BaseManager,  IProgressBarSkillsService
    {
        public ProgressBarSkillsManager(IUnitOfWork uow, IMapper mapper) : base(mapper, uow)
        {
            
        }
        public async Task<IDataResult<List<ProgressBarSkillsListDto>>> GetActiveProgressbarSkills()
        {
            var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
            var result = await repository.GetAllAsync(x => x.IsActive == true);
            if (result == null)
                return new NotFoundResult<List<ProgressBarSkillsListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<ProgressBarSkillsListDto>>(result);

            if (Dto == null)
                return new MappingError<List<ProgressBarSkillsListDto>>(ProcessResult.MappingError);

            return new DataResult<List<ProgressBarSkillsListDto>>(Dto, ResultStatus.Success);
        }
    }
}
