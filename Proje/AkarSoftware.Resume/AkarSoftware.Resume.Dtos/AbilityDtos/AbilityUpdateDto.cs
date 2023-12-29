using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.AbilityDtos
{
    public class AbilityUpdateDto :BaseUpdateDto
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }
        public string UrlPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
