using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
	public class AboutMeConfiguration : IEntityTypeConfiguration<AboutMe>
	{
		public void Configure(EntityTypeBuilder<AboutMe> builder)
		{
			// Burası ile ilgili bir konfigürasyon yapımasını düşünmüyorum 
		}
	}
}
