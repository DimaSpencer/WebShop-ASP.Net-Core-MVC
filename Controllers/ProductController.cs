using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XESShop.Data;
using XESShop.Models;
using XESShop.Models.ProductFiltersAndSorters;

namespace XESShop.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id is null)
                return BadRequest();

            Product product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            
            if (product is null)
                return NotFound($"Product with ID={id} not found");

            return View(product);
        }

        [HttpPost]
        public async Task<IEnumerable<Product>> FilterProducts(bool byCategory, bool byManufacturer, bool byPrice)
        {
            IProductFilter productFilter = null;

            if (byCategory)
                productFilter = new FilterByCategory(await _dbContext.Categories.FirstOrDefaultAsync(c=>c.Id == 228), productFilter);
            if (byManufacturer)
                productFilter = new FilterByManufacturer(await _dbContext.Manufacturers.FirstOrDefaultAsync(c => c.Id == 228), productFilter);
            if (byPrice)
                productFilter = new FilterByPrice(from: 10, to: 11, productFilter);

            IEnumerable<Product> products = productFilter.Filter(_dbContext.Products.ToList());
            return products;
        }
    }
}
