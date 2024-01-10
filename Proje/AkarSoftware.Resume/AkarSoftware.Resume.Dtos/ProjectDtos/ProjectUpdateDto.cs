using Microsoft.AspNetCore.Http;

namespace AkarSoftware.Resume.Dtos.ProjectDtos
{
	public class ProjectUpdateDto
	{
		public string Name { get; set; }
		public string ProjectImageURL { get; set; }
		public bool IsDevelopment { get; set; }
		public string Description { get; set; }
        public string ShortDescription { get; set; }
		public IFormFile File { get; set; }
        public DateTime? CreatedDate { get; set; }
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public DateTime ModifiedDate { get; set; }
        public DateTime ProjectCreateDate { get; set; }
        public int ProjectType { get; set; }


    }
}
