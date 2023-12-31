using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class ExperianceSeeds : IEntityTypeConfiguration<Experiance>
    {
        public void Configure(EntityTypeBuilder<Experiance> builder)
        {
            builder.HasData(
                 new Experiance
                 {
                     Id = 1,
                     IsActive = true,
                     CreatedDate = DateTime.Now,
                     StartDate = new DateTime(2022, 6, 01),
                     EndDate = new DateTime(2023, 7, 01),
                     EducationDescription = "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Horoz ERP projesi kapsamında N-Tier Achitechture Devexpress, Windows Form, Oracle ve şirket i&ccedil;i geliştirilmiş olan birtakım teknolojiler kullanılarak ERP projesi geliştirildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Honest &uuml;zerinden kullanıcılara destek verildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Kurum ihtiya&ccedil;ları doğrultusunda yazılım ekibi ile beraber yazılım geliştirme s&uuml;re&ccedil;lerinde yer alındı.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">Dağıtım alan dışı, Rota optimizasyonu, Otomatik eskalasyon, E-İhracat projelerinde rol alındı.</li>\r\n</ul>",
                     EndDateFormat = "MM/yyyy",
                     StartDateFormat = "MM/yyyy",
                     ModifiedDate = DateTime.Now,
                     Name = "Horoz Lojistik Kargo Hizmetleri A.Ş.",
                     SubName = "Yazılım Uzmanı",
                     ImagePath = "/StaticFiles/hl.png"
                 },
                new Experiance
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2022, 4, 01),
                    EndDate = new DateTime(2022, 6, 30),
                    EducationDescription = "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">Firma b&uuml;nyesinde Yazılım M&uuml;hendisi &uuml;nvanı ile .Net Core Web Api, Sql Server teknolojisini kullanarak backend projeleri geliştirdim.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Turkish Cargo Ara&ccedil; Backend ve Powerşarj projelerinde yer alındı. Geliştirme &ccedil;alışmalarında bulunuldu.</li>\r\n</ul>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "White Rose",
                    SubName = "Yazılım Mühendisi",
                    ImagePath = "/StaticFiles/wr.png"
                },
                new Experiance
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2021, 8, 01),
                    EndDate = new DateTime(2021, 9, 01),
                    EducationDescription = "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">SAP ABAP &uuml;zerinde eğitimler alındı.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">ABAP &uuml;zerinde programlama, geliştirme ve mod&uuml;llerin kullanımı &ouml;ğrenildi.</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">ODI ve BODS ile ETL s&uuml;re&ccedil;leri ger&ccedil;ekleştirildi.&nbsp;</li>\r\n</ul>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "TeamPro Danışmanlık Ve Bilişim Hizmetleri",
                    SubName = "Stajer",
                    ImagePath = "/StaticFiles/teampro.jpg"
                },
                new Experiance
                {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2021, 01, 01),
                    EndDate = new DateTime(2021, 06, 01),
                    EducationDescription = "<ul style=\"box-sizing: border-box; margin: 0px; padding: 0px; list-style-type: none; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 0px; padding: 0px;\">Firma b&uuml;nyesinde u&ccedil;tan uca veri bilimi s&uuml;re&ccedil;leri i&ccedil;erisinde bulunuldu.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Tensorflow, Sklearn, Matplotlib, Seaborn, Plotly k&uuml;t&uuml;phanelerini kullanarak veri bilimi projeleri ve veri analizleri ger&ccedil;ekleştirildi.&nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Knime, Weka ile u&ccedil;tan uca veri bilimi ara&ccedil;larını kullanarak projeler ger&ccedil;ekleştirildi. &Ccedil;ıkan modeller analiz edildi.&nbsp; &nbsp;</li>\r\n<li style=\"box-sizing: border-box; max-height: 1e+06px; list-style-position: inside; list-style-type: disc; margin: 8px 0px 0px; padding: 0px;\">Geliştirilen modelleri sekt&ouml;rde bilindik olan ara&ccedil;lar ile karşılaştırarak istatiksel olarak a&ccedil;ıklayacak makaleler yazdım.</li>\r\n</ul>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "Optiwisdom",
                    SubName = "Stajer",
                    ImagePath = "/StaticFiles/Optiwisdom.jpg"
                },
                new Experiance
                {
                    Id = 5,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    StartDate = new DateTime(2018, 8, 01),
                    EndDate = new DateTime(2018, 10, 01),
                    EducationDescription = "<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull; Nesne y&ouml;nelimli programlama y&ouml;ntemleri ile oluşturulmuş bir iş s&uuml;recinin katmanlı mimari ile geliştirilmesini g&ouml;zlemledim.</p>\r\n<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull; Daha &ouml;ncesinde sadece teorik bilgi sahibi olduğum sunucu sistemlerini ve sunucu elemanlarını yakından g&ouml;zlemledim, oluşan hasarlarda hasar tespiti yaptım ve m&uuml;mk&uuml;nse hasarın tamiratını ger&ccedil;ekleştirdim.</p>\r\n<p style=\"box-sizing: border-box; margin: 0px 0px 1rem; max-height: 1e+06px;  font-family: Rubik-Regular, Helvetica, Arial, sans-serif; font-size: 14px; white-space: normal; \">&bull;Windows Server 2012 R2 işletim sisteminde Active Directory, Group policy gibi yapılar ile domaine bağlı makinelerin dosya erişimlerinde yetkilendirmeler yaptım, Domain'e bağlı makinelere sanal bir ortam &uuml;zerinde yetkiler verdim.</p>",
                    EndDateFormat = "MM/yyyy",
                    StartDateFormat = "MM/yyyy",
                    ModifiedDate = DateTime.Now,
                    Name = "Diler Holding",
                    SubName = "Stajer",
                    ImagePath = "/StaticFiles/diler.jpg"
                }





                );
        }
    }
}
