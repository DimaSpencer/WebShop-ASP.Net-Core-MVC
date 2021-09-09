using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class Manufacturer : IEvaluated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Picture Logo { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Comment> Сomments { get; set; } = new List<Comment>();

        [NotMapped]
        public double AverageRating
        {
            get
            {
                double all = 0;
                double commentsCount = Сomments.Count;

                Сomments.ForEach(c => all += c.Grade);

                double averageRating = all / commentsCount;
                return averageRating;
            }
        }

        public async Task SetPictureAsync(FileSaver fileSaver, IFormFile file)
        {
            Logo = await fileSaver.CreateAndSavePictureAsync<Picture>(file, "/images/manufacturerlogos/");
        }
    }
}
