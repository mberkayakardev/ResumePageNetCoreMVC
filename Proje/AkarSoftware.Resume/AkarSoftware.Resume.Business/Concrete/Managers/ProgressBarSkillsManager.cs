using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.ProgressBarSkillsDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using FluentValidation;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ProgressBarSkillsManager : BaseManager, IProgressBarSkillsService
    {
        private readonly IValidator<ProgressBarSkillsUpdateDto> _UpdateValidator;
        private readonly IValidator<ProgressBarSkillsCreateDto> _CreateValidator;

        public ProgressBarSkillsManager(IUnitOfWork uow, IMapper mapper, IValidator<ProgressBarSkillsCreateDto> createValidator, IValidator<ProgressBarSkillsUpdateDto> updateValidator) : base(mapper, uow)
        {
            _CreateValidator = createValidator;
            _UpdateValidator = updateValidator;
        }

        public async Task<IResult> Create(ProgressBarSkillsCreateDto dto)
        {
            var validationresult = _CreateValidator.Validate(dto);
            if (validationresult.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
                var Duplicated = await repository.AnyAsync(x => x.SkillName.ToUpper().Trim() == dto.SkillName.ToUpper().Trim());
                if (Duplicated)
                {
                    return new Result(ResultStatus.Error, "Mükkerrer veri oluşturulamaz");
                }
                else
                {
                    var model = _Mapper.Map<ProgressBarSkills>(dto);
                    await repository.UpdateAsync(model);
                    await _UnitOfWork.SaveChangesAsync();
                    return new Result(ResultStatus.Success, "Kayıt işlemi başarılı ");
                }


            }

            return new Result(ResultStatus.ValidationError, "Validasyon hataları mevcut");
        }

        public async Task<IResult> Delete(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
            var model = await repository.GetAsync(x => x.Id == id);
            await repository.DeleteAsync(model);
            await _UnitOfWork.SaveChangesAsync();
            return new Result(ResultStatus.Success, "Silme işlemi başarı ile gerçekleşti ");
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

        public async Task<IDataResult<ProgressBarSkillsUpdateDto>> GetById(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
            var result = await repository.GetAsync(x => x.Id == id);
            if (result == null)
                return new NotFoundResult<ProgressBarSkillsUpdateDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<ProgressBarSkillsUpdateDto>(result);

            if (Dto == null)
                return new MappingError<ProgressBarSkillsUpdateDto>(ProcessResult.MappingError);

            return new DataResult<ProgressBarSkillsUpdateDto>(Dto, ResultStatus.Success);
        }

        public async Task<IDataResult<List<ProgressBarSkillsListDto>>> GetProgressbarSkillsWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
            var result = await repository.GetAllAsync();
            if (result == null)
                return new NotFoundResult<List<ProgressBarSkillsListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<ProgressBarSkillsListDto>>(result);

            if (Dto == null)
                return new MappingError<List<ProgressBarSkillsListDto>>(ProcessResult.MappingError);

            return new DataResult<List<ProgressBarSkillsListDto>>(Dto, ResultStatus.Success);
        }

        public async Task<IResult> Update(ProgressBarSkillsUpdateDto dto)
        {
            var validationresult = _UpdateValidator.Validate(dto);
            if (validationresult.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<ProgressBarSkills>();
                var Duplicated = await repository.AnyAsync(x => x.SkillName.ToUpper().Trim() == dto.SkillName.ToUpper().Trim() && x.Id != dto.Id);
                if (Duplicated)
                {
                    return new Result(ResultStatus.Error, "Mükkerrer veri oluşturulamaz");
                }
                else
                {
                    var model = _Mapper.Map<ProgressBarSkills>(dto);
                    await repository.UpdateAsync(model);
                    await _UnitOfWork.SaveChangesAsync();
                    return new Result(ResultStatus.Success, "Güncelleme işlemi başarılı ");
                }


            }

            return new Result(ResultStatus.ValidationError, "Validasyon hataları mevcut", validationresult.GetErrors());
        }
    }
}
