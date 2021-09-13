using Microsoft.EntityFrameworkCore;

namespace XESShop.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int IdentityId { get; set; }
        public Identity Identity { get; set; }

        public string Street { get; set; }
        public string City { get; set; }

        public string Postcode { get; set; }
    }
}
