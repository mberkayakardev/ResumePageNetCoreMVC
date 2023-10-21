using Akar.Portfolio.Shared.Utilities.Messages;
using Akar.Portfolio.Shared.Utilities.Response.Abstract;
using Akar.Portfolio.Shared.Utilities.Response;
using static Akar.Portfolio.Shared.Utilities.Messages.Messages;

namespace Akar.Portfolio.Managers.Abstract
{
    public interface IGenericService<T, TCreateDto, TUpdateDto, TDeleteDto, TListDto>
    {
        Task<IResponse<TCreateDto>> AddAsync(TCreateDto item);
        Task<IResponse> DeleteAsync(TDeleteDto item);
        Task<IResponse<TListDto>> GetAsync(Func<T, bool> where = null);
        Task<IResponse<TListDto>> GetByIdAsync(int id);
        Task<IResponse<IEnumerable<TListDto>>> GetListAsync(Func<T, bool> where = null);
        Task<IResponse> SoftDeleteAsync(TDeleteDto item);
        Task<IResponse<TUpdateDto>> UpdateAsync(TUpdateDto item);
    }
}
