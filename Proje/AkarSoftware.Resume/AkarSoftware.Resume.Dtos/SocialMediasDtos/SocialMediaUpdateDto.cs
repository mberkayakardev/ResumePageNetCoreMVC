using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.SocialMediasDto
{
    public class SocialMediaUpdateDto : BaseUpdateDto
    {
        public string SocialMediaName { get; set; }
        public string SocialMediaUserName { get; set; }
        public string SocialMediaUrl { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
