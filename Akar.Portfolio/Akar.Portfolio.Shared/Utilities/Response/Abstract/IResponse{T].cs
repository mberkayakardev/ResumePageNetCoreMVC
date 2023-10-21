using Akar.Portfolio.Shared.Utilities.Response;

namespace Akar.Portfolio.Shared.Utilities.Response.Abstract
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; set; }
        List<CostumeValidationError> Errors { get; set; }
    }
}
