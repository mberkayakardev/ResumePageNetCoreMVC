using AkarSoftware.Resume.Core.Dtos.Abstract;


namespace AkarSoftware.Resume.Dtos.ExperianceDtos
{
    public class ExperianceListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string ImagePath { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string? StartDateFormat { get; set; } // DD, MM , YYYY vb 
        public string? EndDateFormat { get; set; } // DD, MM , YYYY vb 
        public string EducationDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
