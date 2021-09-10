using Microsoft.EntityFrameworkCore;

namespace XESShop.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int IdentityId { get; set; }
        public Identity Identity { get; set; }

        public string Street { get; set; }
    }
}
