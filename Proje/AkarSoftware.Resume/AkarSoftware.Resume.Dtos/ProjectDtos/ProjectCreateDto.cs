namespace AkarSoftware.Resume.Dtos.ProjectDtos
{
	public class ProjectCreateDto
	{
		public string Name { get; set; }
		public string ProjectImageURL { get; set; }
		public bool IsDevelopment { get; set; }
		public string Description { get; set; }
		public DateTime? CreatedDate { get; set; }
		public bool IsActive { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
