using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Picture Image { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        public async Task SetPictureAsync(FileSaver fileSaver, IFormFile file)
        {
            Image = await fileSaver.CreateAndSavePictureAsync<Picture>(file, "/images/categories/");
        }
    }
}
