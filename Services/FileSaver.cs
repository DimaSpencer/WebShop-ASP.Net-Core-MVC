using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class FileSaver
    {
        private IWebHostEnvironment _environment;
        public FileSaver(IWebHostEnvironment enviroment)
        {
            _environment = enviroment;
        }

        public async Task<T> CreateAndSavePictureAsync<T>(IFormFile file, string directoryPaht)
            where T : Picture, new()
        {
            string webRootPath = _environment.ContentRootPath;

            string pictureName = file.FileName.Replace(' ', '_');
            string picturePath = directoryPaht + pictureName;

            using (var fileStream = new FileStream(webRootPath + picturePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return new T { Name = pictureName, Path = picturePath };
        }
    }
}
