using AkarSoftware.Resume.Core.DataAccess.EntityFramework.Abstract;
using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        #region Repositories 
        //IProductRepository ProductRepository { get; }  // Costume Repositoryler Property şeklinde eklenmelidir. Burada bu
        #endregion

        public IEfGenericRepository<T> GetGenericRepository<T>() where T : class, IEntity, new();
        public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new();
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
