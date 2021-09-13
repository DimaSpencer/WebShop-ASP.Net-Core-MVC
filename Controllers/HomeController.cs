using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XESShop.Data;
using XESShop.Models;
using XESShop.Models.ProductFiltersAndSorters;

namespace XESShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly List<Product> _products;
        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            _products = _dbContext.Products
                 .Include(p => p.Category)
                 .Include(p => p.Manufacturer)
                 .ToList();
        }

        [HttpGet]
        public IActionResult Index()
        {
            
            return View(_products);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FilterProducts(FilterViewModel filterViewModel)
        {
            IProductFilter productFilter = null;

            if (filterViewModel.CategoryId != null)
            {
                Category category = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == filterViewModel.CategoryId);
                if (category is null)
                    ModelState.AddModelError("", "Такой категории нету");

                productFilter = new FilterByCategory(category, productFilter);
            }
            if (filterViewModel.ManufacturerId != null)
            {
                Manufacturer manufacturer = await _dbContext.Manufacturers.FirstOrDefaultAsync(m => m.Id == filterViewModel.ManufacturerId);
                if (manufacturer is null)
                    ModelState.AddModelError("", "Такого производителя нету");

                productFilter = new FilterByManufacturer(manufacturer, productFilter);
            }
            if (filterViewModel.PriceFrom != null && filterViewModel.PriceTo != null)
            {
                productFilter = new FilterByPrice(
                    from: (decimal)filterViewModel.PriceFrom,
                    to: (decimal)filterViewModel.PriceTo,
                    productFilter);
            }

            if (productFilter is null)
                ModelState.AddModelError("", "Фильтр не выбрано");

            if (ModelState.ErrorCount > 0)
                return View("Index");

            var filterProduct = productFilter.Filter(_products);
            return View("_ItemsLoadPartial", filterProduct);
        }
    }
}
