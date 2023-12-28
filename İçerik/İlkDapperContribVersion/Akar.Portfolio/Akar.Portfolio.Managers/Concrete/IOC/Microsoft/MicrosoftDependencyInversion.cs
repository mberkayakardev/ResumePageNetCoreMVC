using Akar.Portfolio.DataAccess.Abstract;
using Akar.Portfolio.DataAccess.Abstract.İnterface;
using Akar.Portfolio.DataAccess.Concrete;
using Akar.Portfolio.DataAccess.Concrete.Dapper;
using Akar.Portfolio.DataAccess.Concrete.DbContext;
using Akar.Portfolio.Dtos.Concrete.AppUser;
using Akar.Portfolio.Dtos.Concrete.ComponentDtos;
using Akar.Portfolio.Dtos.Concrete.IntroduceDtos;
using Akar.Portfolio.Dtos.Concrete.SocialMedia;
using Akar.Portfolio.Managers.Abstract;
using Akar.Portfolio.Managers.Concrete.Managers;
using Akar.Portfolio.Managers.Concrete.ProjectSettings;
using Akar.Portfolio.Managers.Concrete.ValidatonRules.AppUser;
using Akar.Portfolio.Managers.Concrete.ValidatonRules.Components;
using Akar.Portfolio.Managers.Concrete.ValidatonRules.Introduce;
using Akar.Portfolio.Managers.Concrete.ValidatonRules.SocialMedia;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Akar.Portfolio.Managers.Concrete.IOC.Microsoft
{
    public static class MicrosoftDependencyInversion
    {
        public static void AddServiceConfiguraion(this IServiceCollection services, IConfiguration configuration)
        {
            AddConfiguration(services, configuration);

            AddUnitOfWork(services);

            AddDependencies(services);

            AddDbConfiguration(services, configuration);

            AddMapper(services);

            AddValidatons(services);
        }

        /// Configurationlar ekler
        /// 
        public static void AddConfiguration(IServiceCollection Services, IConfiguration Configuration)
        {
            var environment = Configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT");
            var appSettingsFileName = $"appsettings.{environment}.json";
            var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), appSettingsFileName);
            var appSettings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appSettingsPath, optional: true)
                .Build();
            Services.Configure<ProjectSettings.AppSettings>(Configuration.GetSection("AppSettings"));

            Services.AddSession();
        }


        /// <summary>
        /// Repository ve Manager karşılıkları buraya eklenecek  
        /// </summary>
        public static void AddDependencies(IServiceCollection Services)
        {
            ///Register GenericServices

            Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<,,,,>), typeof(GenericManager<,,,,>));

            Services.AddScoped<IComponentService, ComponentManager>();
            Services.AddScoped<IAppUserService, AppUserManager>();
            Services.AddScoped<ISocialMediaService, SocialMediaManager>();




        }

        /// <summary>
        ///  Unit Of Work entegrasyonu sağlandı
        /// </summary>
        public static void AddUnitOfWork(IServiceCollection Services)
        {
            Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }


        /// <summary>
        ///  Unit Of Work entegrasyonu sağlandı
        /// </summary>
        public static void AddDbConfiguration(IServiceCollection Services, IConfiguration configuration)
        {
            var preciseConfig = configuration.GetSection("AppSettings").Get<AppSettings>();
            Services.AddTransient<IDbConnection>(conn => new SqlConnection(preciseConfig.DatabaseConnectionString));
            //Services.AddIdentity<IdentityUser, IdentityRole>(AddCostumizationForIdentity);
            //Services.AddDbContext<MyDbContext>(option => { option.UseSqlServer(preciseConfig.DatabaseConnectionString); });
        }


        /// <summary>
        ///  AutoMapper konfigürasyonu Buraya eklenecektir
        /// </summary>
        /// <param name="Services"></param>
        private static void AddMapper(IServiceCollection Services)
        {
            Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        /// <summary>
        ///  Dto Rules buraya eklenecektir. 
        /// </summary>
        private static void AddValidatons(IServiceCollection services)
        {
            services.AddTransient<IValidator<AddIntroduceDto>, AddIntroduceRules>();
            services.AddTransient<IValidator<UpdateIntroduceDto>, UpdateIntroduceRules>();
            services.AddTransient<IValidator<DeleteIntroduceDto>, DeleteIntroduceRules>();



            services.AddTransient<IValidator<AddComponentDto>, AddComponentRules>();
            services.AddTransient<IValidator<UpdateComponentDto>, UpdateComponenteRules>();
            services.AddTransient<IValidator<DeleteComponentDto>, DeleteComponentRules>();


            services.AddTransient<IValidator<AddAppUserDto>, AddAppUserRules>();
            services.AddTransient<IValidator<UpdateAppUserDto>, UpdateAppUserRules>();
            services.AddTransient<IValidator<DeleteAppUserDto>, DeleteAppUserRules>();


            services.AddTransient<IValidator<AddSocialMediaDto>, AddSocialMediaRules>();
            services.AddTransient<IValidator<UpdateSocialMediaDto>, UpdateSocialMediaRules>();
            services.AddTransient<IValidator<DeleteSocialMediaDto>, DeleteSocialMediaRules>();


        }

        private static void AddCostumizationForIdentity(IdentityOptions options)
        {
            
        }
    }
}
