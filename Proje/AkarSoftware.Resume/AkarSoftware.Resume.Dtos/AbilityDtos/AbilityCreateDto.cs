using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.AbilityDtos
{
    public class AbilityCreateDto : IDto
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public int OrderNumber { get; set; }
		public string UrlPath { get; set; }

	}
}
