using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.ComplexTypes;
using AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.AboutMeDto;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using FluentValidation;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
	public class AboutMeManager : BaseManager, IAboutMeServices
	{
        private readonly IValidator<AboutMeUpdateDto> _UpdateValidator;
        public AboutMeManager(IUnitOfWork UnitOfWork, IMapper _MApper, IValidator<AboutMeUpdateDto> updateValidator) : base(_MApper, UnitOfWork)
        {
            _UpdateValidator = updateValidator;
        }

        public async Task<IDataResult<AboutMeListDto>> GetAboutMeForPersonelCard()
		{
			var repository = _UnitOfWork.GetGenericRepository<AboutMe>();
			var result = await repository.GetAsync(x => x.IsActive == true);
			if (result == null)
				return new NotFoundResult<AboutMeListDto>(ProcessResult.NotFound);

			var Dto = _Mapper.Map<AboutMeListDto>(result);

			if (Dto == null)
				return new MappingError<AboutMeListDto>(ProcessResult.MappingError);

			return new DataResult<AboutMeListDto>(Dto, ResultStatus.Success);
		}

        public async Task<IDataResult<AboutMeUpdateDto>> GetAboutMeWithId(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<AboutMe>();
            var result = await repository.GetAsync(x=> x.Id == id); // Son güncellediğim en üste gelsin diye 
            if (result == null)
                return new NotFoundResult<AboutMeUpdateDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<AboutMeUpdateDto>(result);

            if (Dto == null)
                return new MappingError<AboutMeUpdateDto>(ProcessResult.MappingError);

            var BaskaAktifVarmi = repository.GetAsQueryable().Where(x=> x.IsActive == true && x.Id != id).Count() > 0 ? true : false;
            Dto.TumAktifKayitlariPasifeAl = BaskaAktifVarmi;

            return new DataResult<AboutMeUpdateDto>(Dto, ResultStatus.Success);
        }

        public async Task<IDataResult<List<AboutMeListDto>>> GetAllAboutMeWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<AboutMe>();
            var result = await repository.GetAllAsync(where : null, true, x=> x.ModifiedDate, OrderByEnum.Descanding); // Son güncellediğim en üste gelsin diye 
            if (result == null)
                return new NotFoundResult<List<AboutMeListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<AboutMeListDto>>(result);

            if (Dto == null)
                return new MappingError<List<AboutMeListDto>>(ProcessResult.MappingError);

            return new DataResult<List<AboutMeListDto>>(Dto, ResultStatus.Success);
        }

        public async Task<IResult> UpdateAboutMe(AboutMeUpdateDto dto)
        {
            var state = _UpdateValidator.Validate(dto);
            if (state.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<AboutMe>();
                
                var DtoResult = _Mapper.Map<AboutMe>(dto);
                if (DtoResult == null)
                {
                    return new MappingError<AboutMeUpdateDto>(ProcessResult.MappingError);
                }

                await repository.UpdateAsync(DtoResult);
                await _UnitOfWork.SaveChangesAsync();
                return new Result(ResultStatus.Success, "Güncelleme işlemi başarılı");
            }
            return new ValidationErrorResult<AboutMeUpdateDto>(state.GetErrors());
        }
    }
}
