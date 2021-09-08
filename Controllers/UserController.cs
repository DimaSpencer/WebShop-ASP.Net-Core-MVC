using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;
using XESShop.Data;
using XESShop.Models;

namespace XESShop.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _dbContext;
        private readonly IWebHostEnvironment _appEnvironment;
        public UserController(
            UserManager<User> userManager,
            ApplicationDbContext context,
            IWebHostEnvironment appEnvironment)
        {
            _userManager = userManager;
            _dbContext = context;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Info()
        {
            return View(await GetUserAsync());
        }

        [HttpGet]
        public IActionResult GetUserData(string id)
        {
            return View(_userManager.FindByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateName(string newName)
        {
            if (newName is null)
                throw new ArgumentNullException("name is null");

            User user = await GetUserAsync();
            user.UserName = newName;
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Info");
        }

        private async Task<User> GetUserAsync()
        {
            return await _userManager.Users
                .FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
        }
    }
}
