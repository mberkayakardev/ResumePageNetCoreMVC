using AkarSoftware.Resume.Core.DataAccess.EntityFramework.Concrete;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Contexts;
using AkarSoftware.Resume.DataAccess.ObjectModels;
using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Repositories
{
    public class AbilityRepository : EfGenericRepository<Ability>, IAbilityRepository
    {
        public AbilityRepository(MyDbContext context) : base(context)
        {

        }

        public async Task<DataAndOrdersNumber<Ability>> GetByIdWithOrdersNumber(int id)
        {
            var context = _Context as MyDbContext;
            var data = new DataAndOrdersNumber<Ability>
            {
                Data = context.Abilities.Find(id),
                OrdersNumbers = await context.Abilities.Select(x => x.OrderNumber).ToListAsync()
            };
            return data;

        }
    }
}
