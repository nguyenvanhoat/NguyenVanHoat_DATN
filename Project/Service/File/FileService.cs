using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.File
{
    public class FileService : IFileService
    {
        private readonly IHostingEnvironment environment;

        public FileService(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public string UpLoadFile(IFormFile file)
        {
            var fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
                + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(environment.ContentRootPath, "wwwroot", "img", fileName);
            using var filestream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(filestream);
            return fileName;
        }

        public void DeleteFile(string filename)
        {
            var filePath = Path.Combine(environment.ContentRootPath, "wwwroot", "img", filename);
            System.IO.File.Delete(filePath);
        }
    }
}
