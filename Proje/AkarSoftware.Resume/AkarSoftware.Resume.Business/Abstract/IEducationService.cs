using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.EducationDtos;
using AkarSoftware.Resume.Dtos.SocialMediasDto;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IEducationService
    {
        Task<IDataResult<List<EducationListDto>>> GetEducationsActive();
    }
}
