using System.Collections.Generic;

namespace XESShop.Models
{
    public class Manufacturer : IHavePhotos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Picture> Photos { get; set; }
    }
}
