using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XESShop.Models;

namespace XESShop.ViewModels
{
    public class OrderViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public int Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        public List<Product> Product { get; set; }
    }
}