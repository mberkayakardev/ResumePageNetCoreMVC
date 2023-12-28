using AkarSoftware.Resume.Core.Extentions.FluentApi.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Resume.Core.Utilities.Results.BaseResults
{
    public interface IResult
    {
        public ResultStatus Status { get; }
        public string Messages { get; }
        public IEnumerable<ErrorModel> ValidationErrors { get; }
    }
}
