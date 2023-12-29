using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace AkarSoftware.Resume.Core.Extentions.HttpRequest
{
    public static class HttpContextExtentions
    {
        public static bool TryGetValueWithCastingType<T>(this IRequestCookieCollection RequestcookieCollection, IHttpContextAccessor accessor, string key, out T value)
        {
            var CookieString = string.Empty;
            accessor.HttpContext.Request.Cookies.TryGetValue(key, out CookieString);
            if (CookieString != string.Empty)
            {
                value = System.Text.Json.JsonSerializer.Deserialize <T> (CookieString);
                return true;
            }
            else
            {
                value = default;
                return false;
            }



        }
    }
}
