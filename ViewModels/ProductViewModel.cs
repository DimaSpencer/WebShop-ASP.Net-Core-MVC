using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XESShop.Models;

namespace XESShop.ViewModels
{
    public class ProductViewModel
    {
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Range(1, 5000000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public List<IFormFile> Photos { get; set; }
        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}