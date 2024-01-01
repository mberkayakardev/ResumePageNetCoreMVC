using AkarSoftware.Resume.Business.Abstract;
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
using System.Reflection;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class ProjectManager : BaseManager, IProjectService
    {
        private readonly IValidator<ProjectCreateDto> _ProjectCreateValidator;
        public ProjectManager(IUnitOfWork uow, IMapper mapper, IValidator<ProjectCreateDto> projectCreateValidator) : base(mapper, uow)
        {
            _ProjectCreateValidator = projectCreateValidator;
        }
        public async Task<IResult> CreateNewProject(ProjectCreateDto dto)
        {
            var validation = _ProjectCreateValidator.Validate(dto);
            if (validation.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<Project>();
                
                var extension = Path.GetExtension(dto.ProjectImage.FileName);
                var newImageName = Guid.NewGuid().ToString() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StaticFiles", newImageName);
                var fileStream = new FileStream(path, FileMode.Create);
                dto.ProjectImage.CopyTo(fileStream);
                var mappingdata = _Mapper.Map<Project>(dto);
                mappingdata.ProjectImageURL = "/StaticFiles/"+newImageName;
                await repository.CreateAsync(mappingdata);
                _UnitOfWork.SaveChanges();
                return new Result(ResultStatus.Success, "Kayıt işlemi başarılı");

            }
            return new Result(ResultStatus.ValidationError, "Validasyon Hatası Mevcuttur", validation.GetErrors());
        }

        public async Task<IDataResult<ProjectListDto>> GetActiveProjectById(int id)
        {
            var repository = _UnitOfWork.GetGenericRepository<Project>();
            var result = await repository.GetAsync(x => x.IsActive == true && x.Id == id );
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
    }
}
