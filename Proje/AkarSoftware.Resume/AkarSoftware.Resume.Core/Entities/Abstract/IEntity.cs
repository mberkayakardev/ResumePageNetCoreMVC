namespace AkarSoftware.Resume.Core.Entities.Abstract
{
    public interface IEntity 
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
