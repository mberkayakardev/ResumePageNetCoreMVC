using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Business.Concrete.Helpers.File;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.ComplexTypes;
using AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.ProjectDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using FluentValidation;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ProjectManager : BaseManager, IProjectService
    {
        private readonly IValidator<ProjectCreateDto> _ProjectCreateValidator;
        private readonly IValidator<ProjectUpdateDto> _ProjectUpdateValidator;

        public ProjectManager(IUnitOfWork uow, IMapper mapper, IValidator<ProjectCreateDto> projectCreateValidator, IValidator<ProjectUpdateDto> projectUpdateValidator) : base(mapper, uow)
        {
            _ProjectCreateValidator = projectCreateValidator;
            _ProjectUpdateValidator = projectUpdateValidator;
        }
        public async Task<IResult> CreateNewProject(ProjectCreateDto dto)
        {
            var validation = _ProjectCreateValidator.Validate(dto);
            if (validation.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<Project>();

                string Filename = string.Empty;
                var result = FileHelper.AddImageForStaticFiles(dto.ProjectImage, out Filename);
                if (result)
                {
                    var mappingdata = _Mapper.Map<Project>(dto);
                    mappingdata.ProjectImageURL = "/StaticFiles/" + Filename;
                    await repository.CreateAsync(mappingdata);
                    _UnitOfWork.SaveChanges();
                    return new Result(ResultStatus.Success, "Kayıt işlemi başarılı");
                }
                else
                {
                    return new Result(ResultStatus.ValidationError, "Resim KAyıt işlemi sebebi ile gerçekleşemedi ");
                }

            }
            return new Result(ResultStatus.ValidationError, "Validasyon Hatası Mevcuttur", validation.GetErrors());
        }

        public async Task<IDataResult<ProjectListDto>> GetProjectById(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<Project>();
            var result = await repository.GetAsync(x => x.IsActive == true && x.Id == id);
            if (result == null)
                return new NotFoundResult<ProjectListDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<ProjectListDto>(result);

            if (Dto == null)
                return new MappingError<ProjectListDto>(ProcessResult.MappingError);

            return new DataResult<ProjectListDto>(Dto, ResultStatus.Success);
        }

        public async Task<IDataResult<List<ProjectListDto>>> GetActiveProjects()
        {
            var repository = _UnitOfWork.GetGenericRepository<Project>();
            var result = await repository.GetAllAsync(x => x.IsActive == true, OrderByProperty: x => x.ProjectCreateDate, order: OrderByEnum.Descanding);
            if (result == null || result.Count == 0)
                return new NotFoundResult<List<ProjectListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<ProjectListDto>>(result);

            if (Dto == null)
                return new MappingError<List<ProjectListDto>>(ProcessResult.MappingError);

            return new DataResult<List<ProjectListDto>>(Dto, ResultStatus.Success);
        }



        public async Task<IDataResult<ProjectUpdateDto>> GetProjectForUpdateById(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<Project>();
            var result = await repository.GetAsync(x => x.Id == id);
            if (result == null)
                return new NotFoundResult<ProjectUpdateDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<ProjectUpdateDto>(result);

            if (Dto == null)
                return new MappingError<ProjectUpdateDto>(ProcessResult.MappingError);

            return new DataResult<ProjectUpdateDto>(Dto, ResultStatus.Success);
        }

        public async Task<IDataResult<List<ProjectListDto>>> GetAllProjectsWithDeleted()
        {
            var repository = _UnitOfWork.GetGenericRepository<Project>();
            var result = await repository.GetAllAsync(OrderByProperty: x => x.ModifiedDate, order: OrderByEnum.Descanding);
            if (result == null || result.Count == 0)
                return new NotFoundResult<List<ProjectListDto>>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<List<ProjectListDto>>(result);

            if (Dto == null)
                return new MappingError<List<ProjectListDto>>(ProcessResult.MappingError);

            return new DataResult<List<ProjectListDto>>(Dto, ResultStatus.Success);
        }

        public async Task<IResult> UpdateProject(ProjectUpdateDto dto)
        {
            var validation = _ProjectUpdateValidator.Validate(dto);
            if (validation.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<Project>();

                if (dto.File != null)
                {
                    string Filename = string.Empty;
                    var result = FileHelper.UpdateImageForStaticFiles(dto.File, dto.ProjectImageURL, out Filename);
                    if (result)
                    {
                        var mappingdata = _Mapper.Map<Project>(dto);
                        mappingdata.ProjectImageURL = "/StaticFiles/"+Filename;
                        await repository.UpdateAsync(mappingdata);
                        _UnitOfWork.SaveChanges();
                        return new Result(ResultStatus.Success, "Güncelleme işlemi başarılı");
                    }
                    else
                    {
                        return new Result(ResultStatus.ValidationError, "Resim güncellemesi ile ilgili bir problem ile karşılaşıldı ");

                    }
                }
                else
                {
                    var mappingdata = _Mapper.Map<Project>(dto);
                    await repository.UpdateAsync(mappingdata);
                    _UnitOfWork.SaveChanges();
                    return new Result(ResultStatus.Success, "Güncelleme işlemi başarılı");
                }

            }
            return new Result(ResultStatus.ValidationError, "Validasyon Hatası Mevcuttur", validation.GetErrors());
        }
    }
}
