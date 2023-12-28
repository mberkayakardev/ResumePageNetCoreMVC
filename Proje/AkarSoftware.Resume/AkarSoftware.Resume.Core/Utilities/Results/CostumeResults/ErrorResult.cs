using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Resume.Core.Utilities.Results.CostumeResults
{
    public class ErrorResult<T> : DataResult<T>
    {
        public ErrorResult(string Message) : base(default, ResultStatus.Error, Message)
        {

        }
    }
}
