using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Extentions.HttpRequest;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.DataAccess.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class CookieManager : ICookieServices
    {
        private readonly IHttpContextAccessor _HttpContext;
        public CookieManager(IUnitOfWork uow, IMapper _Mapper, IHttpContextAccessor HttpContext) 
        {
            _HttpContext = HttpContext;
        }
        public IDataResult<T> GetTypeCookieValueWithKey<T>(string Key, T itemTypes)
        {
            string result = string.Empty;
            _HttpContext.HttpContext.Request.Cookies.TryGetValueWithCastingType(_HttpContext, Key, out itemTypes);

            if (result != string.Empty)
                return new DataResult<T>(itemTypes, ResultStatus.Success);

            return new NotFoundResult<T>(ProcessResult.NotFound);
        }
        IDataResult<string> ICookieServices.GetStringCookieValueWithKey(string Key)
        {
            string result = string.Empty;
            _HttpContext.HttpContext.Request.Cookies.TryGetValue(Key, out result);
            if (result != string.Empty)
                return new DataResult<string>(result, ResultStatus.Success);
            return new NotFoundResult<string>(ProcessResult.NotFound);
        }

        public IResult AddGenericCookieValueWithKey<T>(string Key, T item)
        {
            string Serializeditem = System.Text.Json.JsonSerializer.Serialize(item);

            try
            {
                _HttpContext.HttpContext.Response.Cookies.Append(Key, Serializeditem);
                return new Result(ResultStatus.Success);
            }
            catch (Exception ex)
            {
                return new Result(ResultStatus.Error, ex.Message);
            }
        }

        public IResult AddStringCookieValueWithKey(string Key, string value)
        {
            try
            {
                _HttpContext.HttpContext.Response.Cookies.Append(Key, "");
                return new Result(ResultStatus.Success);
            }
            catch (Exception ex)
            {
                return new Result(ResultStatus.Error, ex.Message);
            }
        }

    }
}
