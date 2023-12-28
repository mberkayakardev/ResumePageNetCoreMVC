using Akar.Portfolio.Dtos.Concrete.SocialMedia;
using Akar.Portfolio.Entities.Concrete;

namespace Akar.Portfolio.Managers.Abstract
{
    public interface ISocialMediaService : IGenericService<SocialMedias, AddSocialMediaDto, UpdateSocialMediaDto, DeleteSocialMediaDto, ListSocialMediaDto>
    {
    }
}
