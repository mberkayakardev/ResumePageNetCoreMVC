using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.AboutMeDto;

namespace AkarSoftware.Resume.Business.Abstract
{
	public interface IAboutMeServices
    {
		Task<IDataResult<AboutMeListDto>> GetAboutMeForPersonelCard();
	}
}
