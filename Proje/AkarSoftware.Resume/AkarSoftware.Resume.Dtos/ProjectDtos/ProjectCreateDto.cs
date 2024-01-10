using Microsoft.AspNetCore.Http;

namespace AkarSoftware.Resume.Dtos.ProjectDtos
{
	public class ProjectCreateDto
	{
		public string Name { get; set; }
        public DateTime ProjectCreateDate { get; set; }
        public string ProjectImageURL { get; set; }
		public IFormFile ProjectImage { get; set; }
		public string Description { get; set; }
        public string ShortDescription { get; set; }

        public DateTime? CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ProjectType { get; set; }


    }
}
