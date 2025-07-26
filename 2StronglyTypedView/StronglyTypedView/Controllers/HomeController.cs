using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers
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
            var p = new Product
            {
                prodId = 1,
                prodName = "Laptop",
                prodPrice = 50000.00f,
                prodQty = 10
            };
            return View(p);
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
