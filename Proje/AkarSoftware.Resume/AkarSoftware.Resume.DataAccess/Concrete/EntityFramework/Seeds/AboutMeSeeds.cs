using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
	public class AboutMeSeeds : IEntityTypeConfiguration<AboutMe>
	{
		public void Configure(EntityTypeBuilder<AboutMe> builder)
		{
			builder.HasData(
				new AboutMe
				{
					Id = 1,
					CreatedDate = DateTime.Now,
					IsActive = true,
					ModifiedDate = DateTime.Now,
					Description = "<p><strong><strong><strong></strong></strong></strong></p><p><span style=\"letter-spacing: 0\">2021 yılında Düzce Üniversitesi Bilgisayar Mühendisliği bölümünden 3.03 ortalama mezun oldum. Genel olarak üniversite hayatım boyunca teorik ve uygulamalı olarak edinmiş olduğum bilgileri kurumsal firmalarda gerçekleştirmiş olduğum stajlar ve iş deneyimleri ile destekledim. Orta seviyede İngilizce bilgisine sahibim. Öğrenmeye ve çalışmaya açık bir insan olarak eğitim geçmişime ve kişisel&nbsp;</span><span style=\"letter-spacing: 0\">özelliklerime değer katabileceğim bir pozisyonda deneyim kazanmak ve süreçleri&nbsp;</span><span style=\"letter-spacing: 0\">gözlemlemek istiyorum.</span></p><ul><li><em>Çok Katmanlı Mimari</em> ile proje geliştirebiliyorum. (<strong>N-TIER ARCHITECTURE</strong>).</li><li><em>Django, Flask, ASP.NET Core W</em>eb frameworklerini kullanarak projeler geliştirebiliyorum.</li><li><em>MSSQL, MySQL</em>, <em>Oracle</em> ile veri tabanı yönetimi ve modellemesi yapabiliyorum.</li><li><em>Java, C#, Python</em> dillerinde projeler geliştirebiliyorum.&nbsp;</li><li><em>Devexpress, Windows Form, Pyqt5, Tkinter, Jframe</em> kullanarak masaüstü uygulamalar geliştirebiliyorum.</li><li><em>Windows Server 2012 R2</em> kullanım Orta Seviye <em>MacOS, Windows, Linux (Ubuntu)</em> Bilgisi.</li><li><em>Knime , Weka</em> gibi veri madenciliği araçlarını kullanabiliyorum ve <em>Sklearn, TensorFlow</em> kütüphanelerini kullanarak makine öğrenmesi, veri bilimi projeleri geliştirebiliyorum.</li><li><em>ODI</em> ve<em> SAP BODS</em> araçları kullanarak <em>ETL</em> süreçleri gerçekleştirebiliyorum.</li></ul><br><br><ul><li><strong>Github : https://github.com/mberkayakardev</strong></li><li><strong>Linkedin: https://www.linkedin.com/in/berkayakar/</strong></li></ul>"
				});
		}
	}
}
