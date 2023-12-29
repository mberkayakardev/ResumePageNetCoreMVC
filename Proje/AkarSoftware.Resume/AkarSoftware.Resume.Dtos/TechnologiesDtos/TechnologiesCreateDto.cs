using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.TechnologiesDtos
{
    public class TechnologiesCreateDto: IDto
    {
        public string Name { get; set; }
        public string UrlPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
