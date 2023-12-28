using Akar.Portfolio.Dtos.Concrete.AppUser;
using Akar.Portfolio.Entities.Concrete;

namespace Akar.Portfolio.Managers.Abstract
{
    public interface IAppUserService : IGenericService<AppUser, AddAppUserDto, UpdateAppUserDto, DeleteAppUserDto, ListAppUserDto>
    {

    }
}
