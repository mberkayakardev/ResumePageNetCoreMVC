using Akar.Portfolio.Shared.Utilities.Response.Abstract;

namespace Akar.Portfolio.Shared.Utilities.Response
{
    public class Response : IResponse
    {
        #region Tanimlar
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
        #endregion
        public Response(ResponseType type)
        {
            ResponseType = type;
        }
        public Response(ResponseType type, string Message) : this(type)
        {
            this.Message = Message;
        }

    }

    public enum ResponseType
    {
        Success,
        Error,
        ValidationError,
        NotFound
    }
}
