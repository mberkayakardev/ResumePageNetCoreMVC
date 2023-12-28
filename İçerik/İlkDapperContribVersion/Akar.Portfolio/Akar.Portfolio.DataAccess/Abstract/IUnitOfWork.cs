using Akar.Portfolio.DataAccess.Abstract.İnterface;
using Akar.Portfolio.Entities.Abstract;

namespace Akar.Portfolio.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Transaction Başlatma
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Transaction işleme
        /// </summary>
        void Commit();


        /// <summary>
        /// Transaction Geri Alma
        /// </summary>
        void Rollback();


        /// <summary>
        /// Repository entity vastıası ile generic bir şekilde çağırma
        /// </summary>
        IGenericRepository<TEntity> GetGenericRepository<TEntity>() where TEntity : class, IEntity, new();
        /// <summary>
        /// Costume Repository çağrımı yapma 
        /// </summary>
        /// 
        TRepository GetRepository<T, TRepository>() where T : IEntity where TRepository : IGenericRepository<T>;
     
        /// <summary>
        /// Repository bağımsız select işlemi 
        /// </summary>
        public IEnumerable<T> GetData<T>(string Query);

        /// <summary>
        /// Repository bağımsız Tetikleme veya execute işlemleri 
        /// </summary>
        int ExecuteQuery(string Query);
        
    }
}
