using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.AboutMeDto;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IAboutMeServices
    {
		Task<IDataResult<AboutMeListDto>> GetAboutMeForPersonelCard();
        Task<IDataResult<List<AboutMeListDto>>> GetAllAboutMeWithDeleted();
        Task<IDataResult<AboutMeUpdateDto>> GetAboutMeWithId(int id);
        Task<IResult> UpdateAboutMe(AboutMeUpdateDto Dto);



    }
}
