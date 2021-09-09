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

        public async Task<T> CreateAndSavePictureAsync<T>(IFormFile file, string pictureName)
            where T : Picture, new()
        {
            string webRootPath = _environment.ContentRootPath;
            pictureName = pictureName.Replace(' ', '_');

            using (var fileStream = new FileStream(webRootPath + pictureName, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return new T { Name = file.FileName, Path = pictureName };
        }
    }
}
