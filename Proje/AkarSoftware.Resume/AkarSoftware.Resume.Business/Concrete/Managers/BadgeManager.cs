using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Dtos.Abstract;
using AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.BadgetDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using FluentValidation;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class BadgeManager : BaseManager, IBadgeService
    {
        private readonly IValidator<BadgetUpdateDto> _UpdateDtoValidator;
        private readonly IValidator<BadgetCreateDto> _CreateDtoValidator;

        public BadgeManager(IUnitOfWork UnitOfWork, IMapper mapper, IValidator<BadgetUpdateDto> UpdateDtoValidator, IValidator<BadgetCreateDto> createDtoValidator) : base(mapper, UnitOfWork)
        {
            _UpdateDtoValidator = UpdateDtoValidator;
            _CreateDtoValidator = createDtoValidator;

        }

        public async Task<IResult> Add(BadgetCreateDto Dto)
        {
            var result = _CreateDtoValidator.Validate(Dto);
            if (result.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<Badget>();
                var DuplicateData = await repository.AnyAsync(x => x.Name.ToUpper().Trim() == Dto.Name.Trim().ToUpper());
                if (DuplicateData)
                {
                    return new ErrorResult<BadgetUpdateDto>("İlgili rozet sistemde mevcut mükkerrer kayıt oluşturulamaz");
                }
                var mappingdata = _Mapper.Map<Badget>(Dto);
                await repository.CreateAsync(mappingdata);
                await _UnitOfWork.SaveChangesAsync();
                return new Result(ResultStatus.Success, "Ekleme işlemi başarılı ");

            }
            return new Result(ResultStatus.ValidationError, "Validasyon Hatası Mevcuttur", result.GetErrors());
        }

        public async Task<IResult> Delete(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<Badget>();
            var model = await repository.GetAsync(x => x.Id == id );;
            if (model == null)
            {
                return new ErrorResult<BadgetUpdateDto>("İlgili rozet sistemde bulunamadı");
            }
            await repository.DeleteAsync(model);
            await _UnitOfWork.SaveChangesAsync();
            return new Result(ResultStatus.Success, "silme işlemi başarılı ");


        }

        public async Task<IDataResult<List<BadgetListDto>>> GetAllBadgedWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<Badget>();
            var result = await repository.GetAllAsync();
            if (result == null || result.Count == 0)
                return new NotFoundResult<List<BadgetListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<BadgetListDto>>(result);

            if (Dto == null)
                return new MappingError<List<BadgetListDto>>(ProcessResult.MappingError);

            return new DataResult<List<BadgetListDto>>(Dto, ResultStatus.Success);
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

        public async Task<IDataResult<BadgetUpdateDto>> GetById(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<Badget>();
            var result = await repository.GetAsync(x => x.Id == id);
            if (result == null)
                return new NotFoundResult<BadgetUpdateDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<BadgetUpdateDto>(result);

            if (Dto == null)
                return new MappingError<BadgetUpdateDto>(ProcessResult.MappingError);

            return new DataResult<BadgetUpdateDto>(Dto, ResultStatus.Success);
        }

        public async Task<IResult> Update(BadgetUpdateDto Dto)
        {
            var result = _UpdateDtoValidator.Validate(Dto);
            if (result.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<Badget>();
                var DuplicateData = await repository.AnyAsync(x => x.Name.ToUpper().Trim() == Dto.Name.Trim().ToUpper() && x.Id != Dto.Id);
                if (DuplicateData)
                {
                    return new ErrorResult<BadgetUpdateDto>("İlgili rozet sistemde mevcut mükkerrer kayıt oluşturulamaz");
                }
                var mappingdata = _Mapper.Map<Badget>(Dto);
                await repository.UpdateAsync(mappingdata);
                await _UnitOfWork.SaveChangesAsync();
                return new Result(ResultStatus.Success, "Güncelleme işlemi başarılı ");

            }
            return new Result(ResultStatus.ValidationError, "Validasyon Hatası Mevcuttur", result.GetErrors());


        }
    }
}
