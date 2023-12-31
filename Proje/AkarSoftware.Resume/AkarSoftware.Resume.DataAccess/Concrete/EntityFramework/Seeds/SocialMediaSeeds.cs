using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Seeds
{
    public class SocialMediaSeeds : IEntityTypeConfiguration<SocailMedias>
    {
        public void Configure(EntityTypeBuilder<SocailMedias> builder)
        {
            builder.HasData(
                new SocailMedias
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description = "Linkedin Profilim",
                    SocialMediaUrl = "https://www.linkedin.com/in/berkayakar/",
                    SocialMediaUserName = "in/berkayakar",
                    SocialMediaName = "Linkedin",
                    IconName = "font-icon icon-linkedin2"
                },
                new SocailMedias
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    Description = "Github Profilim",
                    SocialMediaUrl = "https://github.com/mberkayakardev",
                    SocialMediaUserName = "in/berkayakar",
                    SocialMediaName = "Linkedin",
                    IconName = "font-icon icon-github"
                }

                );
        }
    }
}
