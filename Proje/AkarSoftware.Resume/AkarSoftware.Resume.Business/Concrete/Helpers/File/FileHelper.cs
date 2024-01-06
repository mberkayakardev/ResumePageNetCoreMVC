using Microsoft.AspNetCore.Http;

namespace AkarSoftware.Resume.Business.Concrete.Helpers.File
{
    public static class FileHelper
    {
        public static bool AddImageForStaticFiles(IFormFile Formfile, out string FileName)
        {
            try
            {
                var extension = Path.GetExtension(Formfile.FileName);
                var newImageName = Guid.NewGuid().ToString() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StaticFiles", newImageName);
                var fileStream = new FileStream(path, FileMode.Create);
                Formfile.CopyTo(fileStream);
                FileName = newImageName;
                return true;
            }
            catch (Exception)
            {
                FileName = string.Empty;
                return false;
            }

        }

        public static bool UpdateImageForStaticFiles(IFormFile Formfile, string OldFileName, out string NewFileName)
        {
            try
            {
                OldFileName = Directory.GetCurrentDirectory() + "/wwwroot".ToString() + OldFileName;
                if (System.IO.File.Exists(OldFileName))
                {
                    System.IO.File.Delete(OldFileName);

                }
                var extension = Path.GetExtension(Formfile.FileName);
                var newImageName = Guid.NewGuid().ToString() + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "StaticFiles", newImageName);
                var fileStream = new FileStream(path, FileMode.Create);
                Formfile.CopyTo(fileStream);
                NewFileName = newImageName;
                return true;
            }
            catch (Exception)
            {
                NewFileName = string.Empty;
                return false;
            }

        }
    }
}
