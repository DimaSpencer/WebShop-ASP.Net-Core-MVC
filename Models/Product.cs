using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class Product
    {
        public int Id { get; }

        public string Name { get; }
        public string Description { get; }
        public double Price { get; }

        public List<Picture> Photo { get; } = new List<Picture>();
        public List<Category> Category { get; } = new List<Category>();
        public Manufacturer Manufacturer { get; }
    }
}
