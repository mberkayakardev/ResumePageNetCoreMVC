using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
	public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string ProjectImageURL { get; set; }
        public bool IsDevelopment { get; set; }
        public string Description { get; set; }
    }
}
