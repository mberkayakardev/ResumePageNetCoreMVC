using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
	public class SocialMediaConfiguration : IEntityTypeConfiguration<SocailMedias>
	{
		public void Configure(EntityTypeBuilder<SocailMedias> builder)
		{
			builder.Property(x => x.SocialMediaName).IsRequired();
			builder.Property(x => x.SocialMediaUserName).IsRequired();
			builder.Property(x => x.SocialMediaUrl).IsRequired();
			builder.Property(x => x.Description).IsRequired();
		}
	}
}
