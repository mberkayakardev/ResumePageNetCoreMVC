using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.Dtos.SocialMediasDto;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface ISocialMediaService
	{
		Task<IDataResult<List<SocialMediaListDto>>> GetSocialMediasActive();


	}
}
