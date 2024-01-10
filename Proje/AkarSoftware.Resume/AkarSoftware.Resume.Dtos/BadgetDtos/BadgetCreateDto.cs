using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.BadgetDtos
{
    public class BadgetCreateDto : IDto
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }  
    }
}
