using AkarSoftware.Resume.Core.Extentions.FluentApi.ComplexTypes;
using FluentValidation.Results;

namespace AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete
{
    public static class FluentApiExtentions
    {
        public static List<ErrorModel> GetErrors(this ValidationResult result)
        {
            var ResultList = new List<ErrorModel>();
            foreach (var error in result.Errors)
            {
                ResultList.Add(new ErrorModel { PropertyName = error.PropertyName, ErrorDescription = error.ErrorMessage });
            }
            return ResultList;
        }

    }
}
