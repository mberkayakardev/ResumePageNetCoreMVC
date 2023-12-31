using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class BadgedSeeds : IEntityTypeConfiguration<Badget>
    {
        public void Configure(EntityTypeBuilder<Badget> builder)
        {
            builder.HasData(

                new Badget
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = ".Net Core",
                },
                new Badget
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = ".Net FrameWork",
                },
                new Badget
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "C#",
                },
                new Badget
                {
                    Id = 4,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = ".Net Core MVC",
                },
                new Badget
                {
                    Id = 5,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = ".Net Framework MVC",
                },
                new Badget
                {
                    Id = 6,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = ".Net Core Web Api",
                },
                new Badget
                {
                    Id = 7,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "RestFull ",
                },
                new Badget
                {
                    Id = 8,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Windows Forms ",
                },
                new Badget
                {
                    Id = 9,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Devexpress",
                },
                new Badget
                {
                    Id = 10,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Ado.Net",
                },
                new Badget
                {
                    Id = 11,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Dapper",
                },
                new Badget
                {
                    Id = 12,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Dapper.Contrib",
                },
                new Badget
                {
                    Id = 13,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Entity Framework",
                },
                new Badget
                {
                    Id = 14,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Sql Server",
                },
                new Badget
                {
                    Id = 15,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "T-SQL",
                },
                new Badget
                {
                    Id = 16,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "PL-SQL",
                },
                new Badget
                {
                    Id = 17,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Oracle",
                },
                new Badget
                {
                    Id = 18,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "ODI",
                },
                new Badget
                {
                    Id = 19,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "SAP BODS",
                },
                new Badget
                {
                    Id = 20,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "AOP",
                },
                new Badget
                {
                    Id = 21,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "JavaScript",
                },
                new Badget
                {
                    Id = 22,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "HTML",
                },
                new Badget
                {
                    Id = 23,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "React",
                },
                new Badget
                {
                    Id = 24,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "CSS",
                },
                new Badget
                {
                    Id = 25,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "BOOSTRAP",
                },
                new Badget
                {
                    Id = 26,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "N-Tier Architecture",
                },
                new Badget
                {
                    Id = 27,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "UnitOfWork",
                },
                new Badget
                {
                    Id = 28,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Repository Desing Pattern",
                }


                );
        }
    }
}
