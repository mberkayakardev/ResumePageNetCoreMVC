using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class EducationSeeds : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData(
                new Education
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2017, 10, 01),
                    EndDate = new DateTime(2021, 10, 01),
                    EducationDescription = "<p>Lisans &ouml;ğrenimim burada ger&ccedil;ekleşti.</p>\r\n<p><strong>Bilgisayar M&uuml;hendisliği</strong> B&ouml;l&uuml;m&uuml; i&ccedil;in <strong>Ortalama : 3.03</strong></p>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "Düzce Üniversitesi",
                    SubName = "Bilgisayar Mühendisliği",
                    ImagePath = "/StaticFiles/duzceuni.png"
                },
                new Education
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2021, 10, 01),
                    EndDate = new DateTime(2022, 4, 01),
                    EducationDescription = "<p>İŞ-KUR kapsamında Nitelikli Bilişim Uzmanlığı eğitimi alındı.</p>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "Bilişim Eğitim Merkezi - IS-KUR",
                    SubName = "Nitelikli Bilişim Uzmanlığı",
                    ImagePath = "/StaticFiles/BilisimEgitimMerkezi.png"
                },
                new Education
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2023, 8, 01),
                    EndDate = new DateTime(2024, 01, 01),
                    EducationDescription = "<p><strong>.Net Core</strong> i&ccedil;in <strong>FullStack</strong> Development &uuml;zerine bir eğitim alındı.</p>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "Bilişim Eğitim Merkezi - IS-KUR",
                    SubName = "Nitelikli Bilişim Uzmanlığı",
                    ImagePath = "/StaticFiles/my,.jpg"
                });
        }
    }
}
