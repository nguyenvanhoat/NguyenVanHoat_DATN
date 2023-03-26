using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.File
{
    public interface IFileService
    {
        string UpLoadFile(IFormFile file);
        void DeleteFile(string filename);
    }
}
