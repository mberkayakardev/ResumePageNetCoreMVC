using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
	public class Project : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ProjectCreateDate{ get; set; }
        public string ProjectImageURL { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }


        
    }
}
