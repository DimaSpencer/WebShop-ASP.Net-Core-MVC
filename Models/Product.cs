using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class Product : IEvaluated
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string BigName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<Picture> Photos { get; set; } = new List<Picture>();

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public List<Comment> Сomments { get; set; } = new List<Comment>();

        //public List<Basket> Baskets { get; set; } = new List<Basket>();

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

        public async Task SetPictureAsync(FileSaver fileSaver, IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
                await fileSaver.CreateAndSavePictureAsync<Picture>(file, "/images/products/");
        }
    }
}
