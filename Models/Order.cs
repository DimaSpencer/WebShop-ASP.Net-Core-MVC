using System.Collections.Generic;

namespace XESShop.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int IdentityId { get; set; }
        public Identity Identity { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        public bool IsConfirmed { get; set; } = false;
        public bool IsDone { get; set; } = false;
    }
}