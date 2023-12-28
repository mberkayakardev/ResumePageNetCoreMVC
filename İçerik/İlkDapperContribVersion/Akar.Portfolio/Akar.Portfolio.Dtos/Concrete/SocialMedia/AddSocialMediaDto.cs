using Akar.Portfolio.Shared.Entities.Abstract;

namespace Akar.Portfolio.Dtos.Concrete.SocialMedia
{
    public class AddSocialMediaDto : IDto
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
        public string FaviconLink { get; set; }
        public bool IsActive { get; set; }
    }
}
