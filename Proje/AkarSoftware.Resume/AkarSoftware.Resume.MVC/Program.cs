using AkarSoftware.Resume.Business.Concrete.CostumeMiddlewaresExtentions;
using AkarSoftware.Resume.Business.Concrete.DependencyResolves.MicrosoftIOC;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

#region Services Register
builder.Services.AddControllersWithViews().
	AddRazorRuntimeCompilation()
	.AddNToastNotifyToastr(new NToastNotify.ToastrOptions
	{
		PositionClass = ToastPositions.TopRight,
		TimeOut = 5000,
		ProgressBar = true,
		CloseButton = true,
	});

builder.Services.AddSession(); // Session eklenmesi gerçekleştirildi. 
builder.Services.AddCostumeDependencies(builder.Configuration, builder.Environment);
#endregion

var app = builder.Build();

#region Middlewares


if (app.Environment.IsDevelopment())
	app.UseDeveloperExceptionPage();
else
{
	app.UseExceptionHandler("/exception");
	app.UseHsts(); // Http yönlendirmeyi zorunlu kılmak için eklenmiştir. 
}

// NToastNotify için eklendi
app.UseNToastNotify();

/// Https Yönlendirme
app.UseHttpsRedirection(); // Http Yönlendirme için 

/// Static Files Middleware
app.UseStaticFiles();
//app.UseStaticFiles(new StaticFileOptions { RequestPath = "/node_modules", FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "/node_modules")) });

// Routing
app.UseRouting();

// CORS
app.UseCors(x => { x.AllowAnyOrigin(); }); // Ajax için gelen her talep burada cors ayarlaması neticesinde filtrelenecek

// Authentication
app.UseAuthentication();

// Authorization
app.UseAuthorization();

// Costume Middlewares 
app.AddCostumeMiddlewares();

// Endpoint (conversational)
app.UseStatusCodePagesWithReExecute("/Error/{0}"); // Costume Exception Handler


app.UseEndpoints(e =>
{
	e.MapControllerRoute(name: "defaults", pattern: "{Area=Layout}/{Controller=Home}/{Action=Index}/{id?}");
});

app.Run();

#endregion

