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
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string SecondName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid number")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 50, MinimumLength = 5)]
        public string Email { get; set; }

        public List<Product> SelectedProducts { get; set; } = new List<Product>(); //значения которые будут создаватся ещё в контроллере

        [Required]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Postcode { get; set; }
    }
}