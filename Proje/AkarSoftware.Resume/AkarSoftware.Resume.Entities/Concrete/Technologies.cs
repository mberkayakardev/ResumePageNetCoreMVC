using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
    public class Technologies :BaseEntity
    {
        public string Name { get; set; }
        public string UrlPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; } 


    }
}
