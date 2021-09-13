using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace XESShop.Models
{
    public class Identity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
