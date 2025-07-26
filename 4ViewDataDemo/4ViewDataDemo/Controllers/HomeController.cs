using System.Diagnostics;
using _4ViewDataDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _4ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["prodId"] = 1;
            ViewData["prodName"] = "Product 1";
            ViewData["prodPrice"] = 100.00;
            ViewData["prodDescription"] = "This is a sample product description.";
            ViewData["prodCategory"] = "Electronics";
            ViewData["prodQty"] = 10;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
