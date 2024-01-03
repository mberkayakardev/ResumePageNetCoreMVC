using AkarSoftware.Resume.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Resume.Core.DataAccess.EntityFramework.Concrete;
using AkarSoftware.Resume.Core.Entities.Abstract;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Contexts;
using AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Repositories;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Costume Services
        public IAbilityRepository AbilityRepository => new AbilityRepository(_Context);
        #endregion
        private readonly MyDbContext _Context;
        public UnitOfWork(MyDbContext context)
        {
            _Context = context;
        }

        [Obsolete("Eski kullanım artık property bazında service çağırılması gerekecektir")]
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new()
        {
            var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _Context);
            return repository;
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _Context.SaveChangesAsync();
        }

        IEfGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
        {
            var repository = new EfGenericRepository<T>(_Context);
            return repository;
        }
    }
}
