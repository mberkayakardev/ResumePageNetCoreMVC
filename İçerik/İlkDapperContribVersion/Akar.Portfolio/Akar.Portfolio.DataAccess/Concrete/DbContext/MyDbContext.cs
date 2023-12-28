using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Akar.Portfolio.DataAccess.Concrete.DbContext
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> DbContextOption) : base(DbContextOption)
        {
            
        }
    }
}
