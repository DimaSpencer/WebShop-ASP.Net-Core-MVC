using Microsoft.AspNetCore.Mvc;

namespace XESShop.Controllers
{
    [Route("[controller]")]
    public class ErrorController : Controller
    {
        [HttpGet("{statusCode}")]
        public IActionResult PageNotFound(int statusCode)
        {
            Response.StatusCode = statusCode;
            return View(statusCode);
        }
    }
}
