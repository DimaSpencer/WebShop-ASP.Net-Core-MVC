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

        [HttpGet]
        public IActionResult AddManufacturer() => View();
        [HttpGet]
        public IActionResult AddCategory() => View();
        [HttpGet]
        public IActionResult AddProduct() => View();

        [HttpPost]
        public async Task<IActionResult> AddManufacturer(ManufacturerViewModel manufacturerViewModel)
        {
            if (ModelState.IsValid)
            {
                Manufacturer manufacturer = new Manufacturer { Name = manufacturerViewModel.Name };
                await manufacturer.SetPictureAsync(_fileSaver, manufacturerViewModel.Logo);

                _dbContext.Manufacturers.Add(manufacturer);
                await _dbContext.SaveChangesAsync();

                return View();
            }
            else
            {
                return View(manufacturerViewModel);
            }
        }
        [HttpPost]

        public async Task<IActionResult> AddCategory(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category() { Name = categoryViewModel.Name };
                await category.SetPictureAsync(_fileSaver, categoryViewModel.Image);

                _dbContext.Categories.Add(category);
                await _dbContext.SaveChangesAsync();

                return View();
            }
            else
            {
                return View(categoryViewModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel productViewModel)
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
