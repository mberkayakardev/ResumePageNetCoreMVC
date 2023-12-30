using AkarSoftware.Resume.Core.Utilities.Security.HashHelper;
using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
	public class AppUserSeeds : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.HasData(
				new AppUser
				{
					Id = 1,
					IsActive = true,
					CreatedDate = DateTime.Now,
					ModifiedDate = DateTime.Now,
					UserName = "mberkayakar",
					Password = HashHelper.CreateSha256Hash("123"),
					Name = "Berkay",
					Surname = "AKAR",
					Position = "Bilgisayar Mühendisi",
					BornDate = new DateTime(1999,5,25),
					Location = "Bayrampaşa / İstanbul",
					PhoneNumber1 = "+90 534 564 34 10",
					PhoneNumber2 = "+90 534 541 34 10",
					CvPath= "/StaticFiles/ProfilFoto.jpg",
					ProfilePhotos = "/StaticFiles/ProfilFoto.jpg",
					Email ="mberkayakar@outlook.com"

				}) ;
		}
	}
}
