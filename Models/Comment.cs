using System.ComponentModel.DataAnnotations;

namespace XESShop.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int WriterId { get; set; }
        public User Writer { get; set; }
        public string Text { get; set; }

        [Range(1, 5)]
        public double Grade { get; set; }
    }
}
