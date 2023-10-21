using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace Akar.Portfolio.Managers.Concrete.Middlewares
{
    public static class StaticDocumentMiddleware
    {

        /// <summary>
        ///  ard arda gelecek olan hem wwwroot hem de libman , node_modules gibi klasörleri son kullanıcıya açmak
        /// </summary>
        public static void AddStaticMiddlewares(this WebApplication app)
        {
            app.UseStaticFiles();
            app.UseStaticFiles( new StaticFileOptions
            {
                RequestPath="/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules"))
            });

        }


        public static void CostumeMiddlewares(this WebApplication app)
        {
            

        }

    }
}
