using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.Entities.Abstract;
using Akar.Portfolio.Entities.Concrete;
using Akar.Portfolio.Managers.Abstract;
using Akar.Portfolio.Managers.Concrete.Extentions;
using Akar.Portfolio.Shared.Entities.Abstract;
using Akar.Portfolio.Shared.Utilities.Messages;
using Akar.Portfolio.Shared.Utilities.Response;
using Akar.Portfolio.Shared.Utilities.Response.Abstract;
using AutoMapper;
using FluentValidation;
using static Akar.Portfolio.Shared.Utilities.Messages.Messages;

namespace Akar.Portfolio.Managers.Concrete.Managers
{
    public class GenericManager<T, TCreateDto, TUpdateDto, TDeleteDto, TListDto> : IGenericService<T, TCreateDto, TUpdateDto, TDeleteDto, TListDto>
        where T : class, IEntity, new()
        where TCreateDto : class, IDto, new()
        where TUpdateDto : class, IDto, new()
        where TDeleteDto : class, IDto, new()
        where TListDto : class, IDto, new()
    {
        private readonly IMapper _mapper;
        private readonly IValidator<TCreateDto> _CreateValidator;
        private readonly IValidator<TUpdateDto> _UpdateValidator;
        private readonly IValidator<TDeleteDto> _DeleteValidator;
        private readonly IUnitOfWork _unitOfWork;

        public GenericManager(IMapper mapper, IValidator<TCreateDto> createValidator, IValidator<TUpdateDto> updateValidator, IValidator<TDeleteDto> deleteValidator, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _CreateValidator = createValidator;
            _UpdateValidator = updateValidator;
            _DeleteValidator = deleteValidator;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResponse<TCreateDto>> AddAsync(TCreateDto item)
        {
            var ValidationResult = _CreateValidator.Validate(item);
            if (ValidationResult.IsValid)
            {
                var model = _mapper.Map<T>(item);
                if (model != null)
                {
                    var repository = _unitOfWork.GetGenericRepository<T>();
                    await repository.AddAsync(model);
                    return new Response<TCreateDto>(ResponseType.Success, CRUD.Added);

                }
                return new Response<TCreateDto>(ResponseType.ValidationError, StatusResult.ValidationError);

            }
            return new Response<TCreateDto>(item, ValidationResult.GetErrors());

        }
        public async Task<IResponse> DeleteAsync(TDeleteDto item)
        {
            var ValidationResult = _DeleteValidator.Validate(item);
            
            if (ValidationResult.IsValid)
            {
                var model = _mapper.Map<T>(item);
                if (model != null)
                {
                    var repository = _unitOfWork.GetGenericRepository<T>();
                    await repository.DeleteAsync(model);
                    return new Response<TCreateDto>(ResponseType.Success, CRUD.Deleted);

                }
                return new Response<TDeleteDto>(ResponseType.ValidationError, StatusResult.ValidationError);

            }
            return new Response<TDeleteDto>(item, ValidationResult.GetErrors());
        }
        public async Task<IResponse<TListDto>> GetAsync(Func<T, bool> where = null)
        {
            var repository = _unitOfWork.GetGenericRepository<T>();
            var result = await repository.GetAsync(where);
            if (result == null)
            {
                return new Response<TListDto>(ResponseType.NotFound, Message: StatusResult.NotFoundMessage);
            }
            var resultDto = _mapper.Map<TListDto>(result);
            return new Response<TListDto>(ResponseType.Success, data: resultDto);

        }
        public async Task<IResponse<TListDto>> GetByIdAsync(int id)
        {
            var repository = _unitOfWork.GetGenericRepository<T>();
            var result = await repository.GetByIdAsync(id);
            if (result == null)
            {
                return new Response<TListDto>(ResponseType.NotFound, Message: StatusResult.NotFoundMessage);
            }
            var resultDto = _mapper.Map<TListDto>(result);
            return new Response<TListDto>(ResponseType.Success, data: resultDto);
        }
        public async Task<IResponse<IEnumerable<TListDto>>> GetListAsync(Func<T, bool> where = null)
        {
            var repository = _unitOfWork.GetGenericRepository<T>();
            var result = await repository.GetListAsync(where);
            if (result == null)
            {
                return new Response<IEnumerable<TListDto>>(ResponseType.NotFound, Message: StatusResult.NotFoundMessage);
            }
            var resultDto = _mapper.Map<IEnumerable<TListDto>>(result);
            return new Response<IEnumerable<TListDto>>(ResponseType.Success, data: resultDto);
        }
        public async Task<IResponse> SoftDeleteAsync(TDeleteDto item)
        {
            var repository = _unitOfWork.GetGenericRepository<T>();
            var model = _mapper.Map<T>(item);
            if (model != null)
            {
                await repository.SoftDeleteAsync(model);
                return new Response(ResponseType.Success, CRUD.Deleted);
            }
            return new Response<TDeleteDto>(ResponseType.ValidationError, CRUD.Deleted);
        }
        public async Task<IResponse<TUpdateDto>> UpdateAsync(TUpdateDto item)
        {
            var repository = _unitOfWork.GetGenericRepository<T>();
            var model = _mapper.Map<T>(item);
            if (model != null)
            {
                await repository.UpdateAsync(model);
                return new Response<TUpdateDto>(ResponseType.Success, item);
            }
            return new Response<TUpdateDto>(ResponseType.Success, item);
        }
    }
}