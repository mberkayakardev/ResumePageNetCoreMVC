using Akar.Portfolio.Shared.Utilities.Response;
using FluentValidation.Results;

namespace Akar.Portfolio.Managers.Concrete.Extentions
{
    public static class FluentValidatonExtention
    {
        public static List<CostumeValidationError> GetErrors(this ValidationResult validatonResult)
        {
            List<CostumeValidationError> ErrorList = new List<CostumeValidationError>();
            
            foreach (var item in validatonResult.Errors)
            {
                ErrorList.Add(new CostumeValidationError { PropertyName = item.PropertyName, ErrorMessage = item.ErrorMessage });
            }
            
            return ErrorList;
        }
    }
}
