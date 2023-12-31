using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class SkillsSeeds : IEntityTypeConfiguration<ProgressBarSkills>
    {
        public void Configure(EntityTypeBuilder<ProgressBarSkills> builder)
        {
            builder.HasData(
                new ProgressBarSkills { SkillName=".Net Core", Id = 1, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 75},
                new ProgressBarSkills { SkillName = ".Net Framework", Id = 2, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 65 },
                new ProgressBarSkills { SkillName = ".Net Core MVC", Id = 3, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 70 },
                new ProgressBarSkills { SkillName = ".Net Core Web Api", Id = 4, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 70},
                new ProgressBarSkills { SkillName = "HTML", Id = 5, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 75 },
                new ProgressBarSkills { SkillName = "CSS", Id = 6, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 50 },
                new ProgressBarSkills { SkillName = "Boostrap", Id = 7, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 70},
                new ProgressBarSkills { SkillName = "JQuery", Id = 8, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 55},
                new ProgressBarSkills { SkillName = "JavaScript", Id = 9, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 40},
                new ProgressBarSkills { SkillName = "C#", Id = 10, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 70 },
                new ProgressBarSkills { SkillName = "Python", Id = 11, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 60 },
                new ProgressBarSkills { SkillName = "Django", Id = 12, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 50 },
                new ProgressBarSkills { SkillName = "Flask", Id = 13, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 25 },
                new ProgressBarSkills { SkillName = "Sql Server - (TSQL)", Id = 14, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 70 },
                new ProgressBarSkills { SkillName = "Oracle - (PL/SQL)", Id = 15, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 75 },
                new ProgressBarSkills { SkillName = "Knime", Id = 16, CreatedDate = DateTime.Now, IsActive = true, ModifiedDate = DateTime.Now, ProgressBarValue = 60 });
        
        }
    }
}
