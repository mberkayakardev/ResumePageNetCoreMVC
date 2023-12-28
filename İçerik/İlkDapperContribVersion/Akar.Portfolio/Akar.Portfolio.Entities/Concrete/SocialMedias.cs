using Akar.Portfolio.Entities.Abstract.Base;
using System.Globalization;

namespace Akar.Portfolio.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("SocialMedias")]
    public class SocialMedias : BaseEntity
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
        public string FaviconLink { get; set; }

    }
}
