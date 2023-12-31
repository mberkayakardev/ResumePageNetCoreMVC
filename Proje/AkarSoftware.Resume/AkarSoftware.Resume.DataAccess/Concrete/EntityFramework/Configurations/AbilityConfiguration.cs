using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
	public class AbilityConfiguration : IEntityTypeConfiguration<Ability>
	{
		public void Configure(EntityTypeBuilder<Ability> builder)
		{
			builder.Property(x=> x.Name).HasMaxLength(256);
		}
	}
}
