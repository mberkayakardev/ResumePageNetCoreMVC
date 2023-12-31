using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
	public class AbilitySeeds : IEntityTypeConfiguration<Ability>
	{
		public void Configure(EntityTypeBuilder<Ability> builder)
		{
			builder.HasData(
				new Ability
				{
					Id = 1,
					Name = "Web Uygulamaları",
					IsActive = true,
					CreatedDate = DateTime.Now,
					Description = ".Net Core MVC, Asp.Net MVC, Flask, Django ile web uygulamaları geliştirebiliyorum",
					OrderNumber = 1,
					ModifiedDate = DateTime.Now,
					UrlPath = "/StaticFiles/website.png"
				},
				new Ability
				{
					Id = 2,
					Name = "Masaüstü Uygulamalar",
					IsActive = true,
					CreatedDate = DateTime.Now,
					Description = "Winform, PyQt5, Tkinter, JFrame ile masaüstü uygulamalar geliştirebiliyorum.",
					OrderNumber = 2,
					ModifiedDate = DateTime.Now,
					UrlPath = "/StaticFiles/computer.png",
				},
				new Ability
				{
					Id = 3,
					Name = "Web Servisler",
					IsActive = true,
					CreatedDate = DateTime.Now,
					Description = "Restfull - Web Api Geliştirmesi Yapabiliyorum",
					OrderNumber = 3,
					ModifiedDate = DateTime.Now,
					UrlPath = "/StaticFiles/api.png"
				},
				new Ability
				{
					Id = 4,
					Name = "Front - End Geliştirme ",
					IsActive = true,
					CreatedDate = DateTime.Now,
					Description = "HTML, CSS, BOOSTRAP, JS, JQUERY, REACT ile ön yüz uygulamaları geliştirebiliyorum",
					OrderNumber = 4,
					ModifiedDate = DateTime.Now,
					UrlPath = "/StaticFiles/frontend.png"
				}

				);
		}
	}
}
