using AkarSoftware.Resume.DataAccess.ObjectModels;
using AkarSoftware.Resume.Entities.Concrete;

namespace AkarSoftware.Resume.DataAccess.Abstract
{
    public interface IAbilityRepository
    {
        public Task<DataAndOrdersNumber<Ability>> GetByIdWithOrdersNumber(int id);

    }
}
