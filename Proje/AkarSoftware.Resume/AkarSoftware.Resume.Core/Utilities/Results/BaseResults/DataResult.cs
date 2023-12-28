using AkarSoftware.Resume.Core.Extentions.FluentApi.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Resume.Core.Utilities.Results.BaseResults
{
    public class DataResult<T> : Result , IDataResult<T>
    {
        public DataResult(T data, ResultStatus status, string Messages) : base(status, Messages)
        {
            this.Data = data;
        }
        public DataResult(T data, ResultStatus status) : base(status)
        {
            this.Data = data;

        }
        public DataResult(T data, ResultStatus status, IEnumerable<ErrorModel> Errors) : base(status, "", Errors)
        {
            this.Data = data;

        }
        public T Data { get; }
    }
}
