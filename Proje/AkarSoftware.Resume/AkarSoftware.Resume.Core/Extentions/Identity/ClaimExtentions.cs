using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace AkarSoftware.Resume.Core.Extentions.Identity
{
    public static class ClaimExtentions
    {
        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(ClaimTypes.Email, email));
        }
        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, name));
        }
        public static void AddNameIdentifier(this ICollection<Claim> claims, string NameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, NameIdentifier));
        }
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            foreach (var item in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }
        }
    }
}
