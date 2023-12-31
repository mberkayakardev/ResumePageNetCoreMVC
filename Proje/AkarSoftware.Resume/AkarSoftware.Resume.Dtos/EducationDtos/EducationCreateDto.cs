using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.EducationDtos
{
    public class EducationCreateDto : IDto
    {
        public string Name { get; set; }
        public string SubName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? StartDateFormat { get; set; } // DD, MM , YYYY vb 
        public string? EndDateFormat { get; set; } // DD, MM , YYYY vb 
        public string EducationDescription { get; set; }
        public string ImagePath { get; set; }



    }
}
