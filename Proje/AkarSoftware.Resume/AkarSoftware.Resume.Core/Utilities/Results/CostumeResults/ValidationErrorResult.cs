using AkarSoftware.Resume.Core.Extentions.FluentApi.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;

namespace AkarSoftware.Resume.Core.Utilities.Results.CostumeResults
{
    public class ValidationErrorResult<T> : DataResult<T>
    {
        public ValidationErrorResult(IEnumerable<ErrorModel> Errors) : base(default, ResultStatus.ValidationError, Errors)
        {

        }
    }
}
