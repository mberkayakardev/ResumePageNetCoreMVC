using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.AbilityDtos
{
    public class AbilityCreateDto : IDto
    {
        public string Description { get; set; }
        public string UrlPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int OrderNumber { get; set; }
    }
}
