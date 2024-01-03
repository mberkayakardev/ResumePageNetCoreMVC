using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Dtos.AppUserDtos;

namespace AkarSoftware.Resume.Business.Abstract
{
    public interface IAppUserService
    {
        Task<IDataResult<AppUserListDto>> GetUserForPersonelCard();
        Task<IResult> LoginService(LoginUserDto dto);
        Task<IResult> LogoutService();


    }
}
