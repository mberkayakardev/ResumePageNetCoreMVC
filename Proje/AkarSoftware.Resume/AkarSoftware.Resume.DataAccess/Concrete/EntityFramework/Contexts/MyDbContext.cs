﻿using AkarSoftware.Resume.Core.Entities.Abstract;
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity EntityReference)
                {
                    EntityReference.ModifiedDate = DateTime.Now;
                    switch (item.State)
                    {
                        case EntityState.Added:
                            EntityReference.CreatedDate = DateTime.Now;
                            break;
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        #region Tables 
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Badget> Badgets { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experiance> Experiances { get; set; }
		public DbSet<ProgressBarSkills> ProgressBarSkillses { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<SocailMedias> SocailMedias { get; set; }
		public DbSet<Technologies> Technologies { get; set; }
		#endregion

	}
}
