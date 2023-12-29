using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface ICookieServices
    {
        public IDataResult<string> GetStringCookieValueWithKey(string Key);
        public IDataResult<T> GetTypeCookieValueWithKey<T>(string Key, T itemTypes);
        public IResult AddStringCookieValueWithKey(string Key, string value);
        public IResult AddGenericCookieValueWithKey<T>(string Key, T item);


    }
}
