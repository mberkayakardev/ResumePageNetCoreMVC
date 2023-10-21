namespace Akar.Portfolio.DataAccess.Abstract.İnterface
{
    /// <summary>
    ///  Generic Methodlarımın yazıldığı repository bilgisi burada mevcuttur 
    /// </summary>
    public interface IGenericRepository <T>
    {
        Task<T> GetAsync(Func<T, bool> where = null);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetListAsync(Func<T, bool> where = null);
        Task AddAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(T item);
        Task SoftDeleteAsync(T item);
    }
}
