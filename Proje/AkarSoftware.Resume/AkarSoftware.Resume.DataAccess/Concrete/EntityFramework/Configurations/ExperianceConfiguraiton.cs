using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Configurations
{
    public class ExperianceConfiguraiton : IEntityTypeConfiguration<Experiance>
    {
        public void Configure(EntityTypeBuilder<Experiance> builder)
        {

        }
    }
}
