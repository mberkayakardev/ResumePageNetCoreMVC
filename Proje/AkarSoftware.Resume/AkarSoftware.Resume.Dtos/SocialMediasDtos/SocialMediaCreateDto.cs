using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.SocialMediasDto
{
    public class SocialMediaCreateDto : IDto
    {
        public string SocialMediaName { get; set; }
        public string SocialMediaUserName { get; set; }
        public string SocialMediaUrl { get; set; }
        public string Description { get; set; }
        public string IconName { get; set; }

    }
}
