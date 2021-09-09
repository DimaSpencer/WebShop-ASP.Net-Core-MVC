using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using XESShop.Data;
using XESShop.Models;
using XESShop.ViewModels;

namespace XESShop.Controllers
{
    [Authorize(Roles = "admin")]
    [Route("[controller]/[action]")]
    public class AdministratorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly FileSaver _fileSaver;
        public AdministratorController(ApplicationDbContext dbContext, FileSaver fileSaver)
        {
            _dbContext = dbContext;
            _fileSaver = fileSaver;
        }

        [HttpPost]
        public async Task<IActionResult> AddManufacturer(ManufacturerViewModel manufacturerViewModel)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel categoryViewModel)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult CreateProduct() => View();

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product() 
                { 
                    Name = productViewModel.Name,
                    Description = productViewModel.Description,
                    Category = productViewModel.Category,
                    Manufacturer = productViewModel.Manufacturer,
                    Price = productViewModel.Price
                };

                await product.SetPictureAsync(_fileSaver, productViewModel.Photos);
                _dbContext.Products.Add(product);
                await _dbContext.SaveChangesAsync();
            }
            return View(productViewModel);
        }
    }
}
