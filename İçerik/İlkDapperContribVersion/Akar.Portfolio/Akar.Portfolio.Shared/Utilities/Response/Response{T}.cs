using Akar.Portfolio.Shared.Utilities.Response.Abstract;

namespace Akar.Portfolio.Shared.Utilities.Response
{
    public class Response<T> : Response, IResponse<T>
    {
        public T Data { get; set; }
        public List<CostumeValidationError> Errors { get; set; }
        public Response(ResponseType response, string Message) : base(response, Message)
        {

        }

        public Response(ResponseType response, T data) : base(response)
        {
            Data = data;
        }


        public Response(T data, List<CostumeValidationError> errors) : base(ResponseType.ValidationError)
        {
            Data = data;
            Errors = errors;
        }



    }
}
