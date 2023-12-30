using AkarSoftware.Resume.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base (opt) 
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        #region Tables 
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Badget> Badgets { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experiance> Experiances { get; set; }
		public DbSet<ProgressBarSkills> ProgressBarSkills { get; set; }
		public DbSet<ProgressBarSkilssMaster> ProgressBarSkilssMasters { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<SocailMedias> SocailMedias { get; set; }
		public DbSet<Technologies> Technologies { get; set; }










		#endregion

	}
}
