using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XESShop.Models
{
    public class User : IdentityUser
    {
        public int AvatarId { get; set; }
        public UserAvatar Avatar { get; set; }
        public Roles Role { get; set; }
    }
}
