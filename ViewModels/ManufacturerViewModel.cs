using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace XESShop.Models
{
    public class ManufacturerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Company name")]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Upload)]
        public IFormFile Logo { get; set; }
    }
}
