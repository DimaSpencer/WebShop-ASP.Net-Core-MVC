using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class User : IdentityUser
    {
        public int IdentityId { get; set; }
        public Identity Identity { get; set; }

        //public int BasketId { get; set; }
        //public Basket Basket { get; set; }

        public List<Order> Orders { get; set; }

        public int AvatarId { get; set; }
        public UserAvatar Avatar { get; set; }
        public Roles Role { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
