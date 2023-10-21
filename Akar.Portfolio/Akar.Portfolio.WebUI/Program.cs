using Akar.Portfolio.Managers.Concrete.IOC.Microsoft;
using Akar.Portfolio.Managers.Concrete.Middlewares;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews();
builder.Services.AddServiceConfiguraion(builder.Configuration);
#endregion

var app = builder.Build();

/// Error Handling
app.UseExceptionHandler("/Error/GetErrors");
app.UseStatusCodePagesWithReExecute("/Error/Status", "?code={0}");



/// Https Redirecton 
if (app.Environment.IsProduction())
    app.UseHttpsRedirection();


/// costume static files and wwwroot configuration
app.AddStaticMiddlewares();

/// Routing
app.UseRouting();

//app.UseAuthentication();

//app.UseAuthorization();


/// EndpointConfiguration 
app.UseEndpoints(endpoints => { endpoints.MapControllerRoute(name: "Default", pattern: "{Area}/{Controller}/{Action}/{id?}", defaults: new { Area = "Resume", Controller = "Resume", Action = "Index" }); });


/// Costume middlewares in business 
app.CostumeMiddlewares();

app.Run();
