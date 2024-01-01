using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.AppUserDtos
{
	public class LoginUserDto:  IDto
	{
		public string UserName { get; set; }	
		public string Password { get; set; }
		public bool RememberMe { get; set; }
		public string ReturnUrl { get; set; }

    }
}
