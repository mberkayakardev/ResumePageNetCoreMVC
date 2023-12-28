using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Resume.Core.Utilities.Results.CostumeResults
{
    public class MappingError<T>: DataResult<T>
    {
        public MappingError() : base(default, ComplexTypes.ResultStatus.MappingError, string.Empty)
        {

        }
        public MappingError(string Message) : base(default, ComplexTypes.ResultStatus.MappingError, Message)
        {

        }
    }
}
