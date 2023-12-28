using System.Reflection.Metadata.Ecma335;

namespace AkarSoftware.Resume.Core.Dtos.Abstract
{
    /// <summary>
    ///  Dto sınıflarımın haricinde tüm update işlemlerini gerçekleştirecek olan dtolarım için bir update Dto sınıfı oluşturuldu 
    /// </summary>
    public interface IUpdateDto : IDto
    {
        public int Id { get; set; }
    }
}
