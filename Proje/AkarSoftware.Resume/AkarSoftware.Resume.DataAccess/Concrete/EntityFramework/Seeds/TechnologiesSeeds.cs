using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class TechnologiesSeeds : IEntityTypeConfiguration<Technologies>
    {
        public void Configure(EntityTypeBuilder<Technologies> builder)
        {
            builder.HasData(
                new Technologies
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Width = 50,
                    Height = 50,
                    ModifiedDate = DateTime.Now,
                    Name = ".Net Core",
                    UrlPath = "/StaticFiles/dotnetcore.svg"
                },
                new Technologies
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Width = 50,
                    Height = 50,
                    ModifiedDate = DateTime.Now,
                    Name = ".Net Framework",
                    UrlPath = "/StaticFiles/dotnetframework.svg"
                },
                new Technologies
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Width = 50,
                    Height = 50,
                    ModifiedDate = DateTime.Now,
                    Name = "C#",
                    UrlPath = "/StaticFiles/csharp.svg"
                },
                new Technologies
                {
                    Id = 5,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Width = 50,
                    Height = 50,
                    ModifiedDate = DateTime.Now,
                    Name = "Python",
                    UrlPath = "/StaticFiles/python.svg"
                },
                new Technologies
                {
                    Id = 6,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Width = 50,
                    Height = 50,
                    ModifiedDate = DateTime.Now,
                    Name = "Django",
                    UrlPath = "/StaticFiles/django.svg"
                }

                );
        }
    }
}
