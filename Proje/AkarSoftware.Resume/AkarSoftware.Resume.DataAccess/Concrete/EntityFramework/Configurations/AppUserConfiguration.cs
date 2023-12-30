using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
	public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.Property(x => x.PhoneNumber1).IsRequired(true);
			
			builder.Property(x => x.UserName).HasMaxLength(500);
			builder.Property(x => x.UserName).IsRequired(true);

			builder.Property(x => x.Password).IsRequired(true);
			
			builder.Property(x=> x.Name).IsRequired(true);
			builder.Property(x => x.Name).HasMaxLength(500);

			builder.Property(x => x.Surname).IsRequired(true);
			builder.Property(x => x.Surname).HasMaxLength(500);

			builder.Property(x => x.Position).IsRequired(true);
			builder.Property(x => x.Position).HasMaxLength(500);

			builder.Property(x => x.BornDate).IsRequired(true);
			
			builder.Property(x => x.Location).IsRequired(true);
			builder.Property(x => x.Location).HasMaxLength(500);

		}
	}
}
