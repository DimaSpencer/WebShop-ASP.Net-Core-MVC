using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XESShop.Data;
using XESShop.Models;
using XESShop.ViewModels;

namespace XESShop.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public OrderController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult ToOrder() => View();

        [HttpPost]
        public async Task<IActionResult> ToOrder(OrderViewModel orderViewModel)
        {
            if (ModelState.IsValid)
            {
                //TODO: нужно поискать, есть ли уже такой Identity
                Address address = new Address
                {
                    City = orderViewModel.City,
                    Street = orderViewModel.Street,
                    Postcode = orderViewModel.Postcode
                };

                Identity identity = new Identity()
                {
                    Address = address,
                    Email = orderViewModel.Email,
                    FirstName = orderViewModel.FirstName,
                    LastName = orderViewModel.LastName,
                    SecondName = orderViewModel.SecondName,
                    Phone = orderViewModel.Phone
                };

                Order order = new Order
                {
                    Identity = identity,
                    Products = orderViewModel.SelectedProducts
                };
                await _appDbContext.Orders.AddAsync(order);
                await _appDbContext.SaveChangesAsync();
                return Content("Благодарим за покупку view");
            }
            return View(orderViewModel);
        }
    }
}
