using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
    public class TechnologiesConfiguration : IEntityTypeConfiguration<Technologies>
    {
        public void Configure(EntityTypeBuilder<Technologies> builder)
        {
            builder.Property(x=> x.Name).HasMaxLength(256);

        }
    }
}
