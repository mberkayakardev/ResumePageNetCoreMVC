using AkarSoftware.Resume.Business.Abstract;
using AkarSoftware.Resume.Business.Concrete.ComplexTypes;
using AkarSoftware.Resume.Business.Concrete.Managers;
using AkarSoftware.Resume.DataAccess.Abstract;
using AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.Contexts;
using AkarSoftware.Resume.DataAccess.Concrete.EntityFramework.UnitOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;


namespace AkarSoftware.Resume.Business.Concrete.DependencyResolves.MicrosoftIOC
{
    public static class MicrosoftIOCDependencyInjection
    {
        public static void AddCostumeDependencies(this IServiceCollection Services, IConfiguration Configuration, IHostEnvironment enviroment)
        {
            AddConfigurationFiles(Services, Configuration);

            AddAnotherConfigurationServices(Services, Configuration);

            AddDbContext(Services, Configuration, enviroment);

            AddUnitOfWork(Services, Configuration);

            AddDependencies(Services);

            AddValidationRules(Services);

            AddMapper(Services);

            AddAuthenticaton(Services, enviroment);
        }
        #region Methods
        /// <summary>
        /// Option pattern ile birlikte multiple appsettings.json u ekler enviroment ortalına göre ilgili appsettings register olur
        /// </summary>
        private static void AddConfigurationFiles(IServiceCollection services, IConfiguration configuration)
        {

            services.Configure<AppSettingsOptions>(x =>
            {
                x.ConnectionString = configuration.GetSection("AppSettings:ConnectionString").Value.ToString();
                x.MainterenceMode = Convert.ToBoolean(configuration.GetSection("AppSettings:MainterenceMode").Value);
            });

        }

        /// <summary>
        /// Cookie, Session, gibi yapılandırmalar eklenir.
        /// </summary>
        private static void AddAnotherConfigurationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// DbContext ayarlandı.
        /// </summary>
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration, IHostEnvironment enviroment)
        {

            services.AddDbContext<MyDbContext>(x =>
            {
                var ConnectionString = configuration.GetSection("ApplicationSettings:ConnectionStrings").Value.ToString();
                x.UseSqlServer(ConnectionString);

                //if (enviroment.IsDevelopment()) // Development modu için Entity Framework Logları incelenmek İstenebilir. 
                //{
                //    x.EnableSensitiveDataLogging(true); // veritabanı loglaması için aktif hale getirildi. 
                //}

            });
   //         if (enviroment.IsDevelopment())
   //         {

			//	using (var serviceProvider = services.BuildServiceProvider())
			//	{
			//		var dbContext = serviceProvider.GetRequiredService<MyDbContext>();
			//		dbContext.Database.Migrate();
			//	}
			//}
        }

        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        /// <summary>
        /// Proje bağlılıkları eklenir.
        /// </summary>
        private static void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<ICookieServices, CookieManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
			services.AddScoped<IAboutMeServices, AboutMeManager>();
            services.AddScoped<IAbiliryService, AbilityManager>();
            services.AddScoped<ITechnologiesService, TechnologiesManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperianceService, ExperianceManager>();
            services.AddScoped<IProgressBarSkillsService, ProgressBarSkillsManager>();
            services.AddScoped<IBadgeService, BadgeManager>();
			services.AddScoped<IProjectService, ProjectManager>();


			



		}
        /// <summary>
        ///  Automapper ekler 
        /// </summary>
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Authentication ayarları buradan yapılmaktadır 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="enviroment"></param>
        private static void AddAuthenticaton(IServiceCollection services, IHostEnvironment enviroment)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
            {
                x.ExpireTimeSpan = TimeSpan.FromDays(20);
                x.SlidingExpiration = true;
                x.AccessDeniedPath = "/forbidden";
                x.LoginPath = "/singin";
                x.LogoutPath= "/singout";

            });

        }


        private static void AddValidationRules(IServiceCollection services)
        {
            #region Fluent Validation Otomatik Register
            var assemblyList = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType != null).Where(x => x.BaseType.Name.Contains("AbstractValidator")).ToList();
            foreach (var item in assemblyList)
            {
                var DtoType = item.BaseType.GetGenericArguments()[0];
                services.AddSingleton(typeof(IValidator<>).MakeGenericType(DtoType), item);
            }
            #endregion
 

        }
        #endregion



    }
}
