using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Picture Logo { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task SetPictureAsync(FileSaver fileSaver, IFormFile file)
        {
            Logo = await fileSaver.CreateAndSavePictureAsync<Picture>(file, "/images/manufacturerlogos/");
        }
    }
}
