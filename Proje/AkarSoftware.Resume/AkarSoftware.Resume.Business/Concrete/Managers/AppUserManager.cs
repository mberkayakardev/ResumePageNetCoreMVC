using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Core.Extentions.FluentApi.Concrete;
using AkarSoftware.Resume.Core.Extentions.Identity;
using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Core.Utilities.Results.CostumeResults;
using AkarSoftware.Resume.Core.Utilities.Security.HashHelper;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using AkarSoftware.Resume.Entities.Concrete;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using static AkarSoftware.Resume.Business.Concrete.ConstVerables.Messages;

namespace AkarSoftware.Resume.Business.Concrete.Managers
{
    public class AppUserManager : BaseManager, IAppUserService
    {
        private readonly IValidator<LoginUserDto> _LoginUserValidator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AppUserManager(IUnitOfWork uow, IMapper mapper, IValidator<LoginUserDto> LoginUserValidator, IHttpContextAccessor httpContextAccessor) : base(mapper, uow)
        {
            _LoginUserValidator = LoginUserValidator;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IDataResult<AppUserListDto>> GetUserForPersonelCard()
        {
            var repository = _UnitOfWork.GetGenericRepository<AppUser>();
            var result = await repository.GetAsync(x => x.IsActive == true);
            if (result == null)
                return new NotFoundResult<AppUserListDto>(ProcessResult.NotFound);

            var Dto = _Mapper.Map<AppUserListDto>(result);

            if (Dto == null)
                return new MappingError<AppUserListDto>(ProcessResult.MappingError);

            return new DataResult<AppUserListDto>(Dto, ResultStatus.Success);

        }

        public async Task<IResult> LoginService(LoginUserDto dto)
        {
            var result = _LoginUserValidator.Validate(dto);
            if (result.IsValid)
            {
                var repository = _UnitOfWork.GetGenericRepository<AppUser>();
                var model = await repository.GetAsync(x => (x.UserName == dto.UserName || x.Email == dto.UserName) && x.Password == HashHelper.CreateSha256Hash(dto.Password));
                if (model == null)
                {
                    return new Result(ResultStatus.NotFound, "İlgili kullanıcı bulunamadı");
                }

                var claims = new List<Claim>();
                claims.AddName(model.Name);
                claims.AddEmail(model.Email);
                claims.AddNameIdentifier(model.UserName);
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = dto.RememberMe
                };
                await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return new Result(ResultStatus.Success, "Giriş Başarılı Hoşgeldiniz");
            }
            return new Result(ResultStatus.ValidationError, "Eksik Kullanıcı Bilgileri mevcut", result.GetErrors());
        }

        public async Task<IResult> LogoutService()
        {
            await _httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new Result(ResultStatus.Success, "Çıkış Gerçekleştirildi");
        }
    }
}
