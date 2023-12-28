using Akar.Portfolio.Shared.Utilities.Response;

namespace Akar.Portfolio.Shared.Utilities.Response.Abstract
{
    public interface IResponse
    {
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
    }
}
