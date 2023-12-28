using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.DataAccess.Abstract.İnterface;
using Akar.Portfolio.DataAccess.Concrete.Dapper;
using Akar.Portfolio.Entities.Abstract;
using Dapper;
using System.Data;

namespace Akar.Portfolio.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Tanimlar
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        private bool _disposed;
        #endregion


        public UnitOfWork(IDbConnection dbConnection)
        {
            _connection = dbConnection;
            _connection.Open();
        }

        #region Transaction İşlemleri
        public void BeginTransaction()
        {
            _transaction = _connection.BeginTransaction();
        }
        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
        }
        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
            }
        }
        #endregion

        #region Query/Execute Operation
        public int ExecuteQuery(string Query)
        {
            var result = _connection.Execute(Query, _transaction);
            return result;
        }
        public IEnumerable<T> GetData<T>(string Query)
        {
            return _connection.Query<T>(Query);
        }
        #endregion

        IGenericRepository<TEntity> IUnitOfWork.GetGenericRepository<TEntity>()
        {
            return new GenericRepository<TEntity>(_connection, _transaction);
        }


        public TRepository GetRepository<T, TRepository>() where T : IEntity where TRepository : IGenericRepository<T>
        {
            return (TRepository)Activator.CreateInstance(typeof(T), _connection, _transaction);
        }
    }
}
