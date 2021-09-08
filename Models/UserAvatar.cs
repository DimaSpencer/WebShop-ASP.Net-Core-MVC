using Microsoft.EntityFrameworkCore;

namespace XESShop.Models
{
    [Owned]
    public class UserAvatar : Picture
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
