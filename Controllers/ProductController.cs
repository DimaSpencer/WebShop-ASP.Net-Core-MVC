using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using XESShop.Data;
using XESShop.Models;
using XESShop.Models.ProductFiltersAndSorters;

namespace XESShop.Controllers
{
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

            Product product = _dbContext.Products
                .Include(p => p.Manufacturer)
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);
            
            if (product is null)
                return NotFound($"Product with ID={id} not found");

            return View(product);
        }

        //[HttpPost]
        //public async Task<IActionResult> AddToBasket(int? id)
        //{
        //    if (id is null)
        //        return BadRequest();

        //    Product product = _dbContext.Products.FirstOrDefault(p => p.Id == id);

        //    if (product is null)
        //        return NotFound("product not found");

        //    User user = await _dbContext.Users
        //        .Include(u => u.Basket)
        //        .ThenInclude(b => b.Products)
        //        .FirstOrDefaultAsync(u => u.UserName == HttpContext.User.Identity.Name);

        //    if (user is null)
        //        return NotFound("user not found");

        //    user.Basket.Products.Add(product);
        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Get", "Product", new { id });
        //}

        
    }
}
