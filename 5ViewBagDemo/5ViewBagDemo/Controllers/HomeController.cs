using System.Diagnostics;
using _5ViewBagDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5ViewBagDemo.Controllers
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
            ViewBag.Roll=1;
            ViewBag.Name = "Pranav Verma";
            ViewBag.Course = "Java";
            ViewBag.Fee = 6500;
            ViewBag.Num1 = 50;
            ViewBag.Num2 = 70;
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
