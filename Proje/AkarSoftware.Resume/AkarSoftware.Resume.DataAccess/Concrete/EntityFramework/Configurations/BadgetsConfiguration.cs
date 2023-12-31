using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
    public class BadgetsConfiguration : IEntityTypeConfiguration<Badget>
    {
        public void Configure(EntityTypeBuilder<Badget> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(200);
        }
    }
}
