namespace Akar.Portfolio.Entities.Abstract
{
    /// <summary>
    ///  ilgili interface sistem içerisindeki sınıflardan entity rolunu üstlenmesi ve entity rolunu üstlenenleri bir araya toplamak maksadı ile eklenmiştir
    /// </summary>
    public interface IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
