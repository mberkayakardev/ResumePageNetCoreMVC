using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Resume.Core.Utilities.Results.CostumeResults
{
    public class NotFoundResult<T> : DataResult<T>
    {
        public NotFoundResult(string Message) : base(default, ResultStatus.NotFound, Message)
        {

        }
        public NotFoundResult() : base(default, ResultStatus.NotFound)
        {

        }
    }
}
