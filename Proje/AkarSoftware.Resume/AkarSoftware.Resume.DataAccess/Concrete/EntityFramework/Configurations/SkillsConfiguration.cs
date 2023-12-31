using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
    public class SkillsConfiguration : IEntityTypeConfiguration<ProgressBarSkills>
    {
        public void Configure(EntityTypeBuilder<ProgressBarSkills> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.ProgressBarValue).HasMaxLength(100);
            builder.Property(x => x.SkillName).HasMaxLength(100);
        }
    }
}
