namespace Akar.Portfolio.Entities.Abstract.Base
{
    /// <summary>
    ///  Tüm entitylerde ortak olan alanlar tek bir class altında toplandı
    /// </summary>
    public class BaseEntity : IEntity
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get ; set ; }
        public bool IsActive { get ; set ; }
    }
}
