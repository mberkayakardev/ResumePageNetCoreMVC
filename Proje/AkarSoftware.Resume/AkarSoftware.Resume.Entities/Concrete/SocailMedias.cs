using AkarSoftware.Resume.Core.Entities.Abstract;

namespace AkarSoftware.Resume.Entities.Concrete
{
    public class SocailMedias : BaseEntity
    {
        public string SocialMediaName { get; set; }
        public string SocialMediaUserName { get; set; }
        public string SocialMediaUrl { get; set; }
        public string Description {  get; set; }
        public string IconName { get; set; }
    }
}
