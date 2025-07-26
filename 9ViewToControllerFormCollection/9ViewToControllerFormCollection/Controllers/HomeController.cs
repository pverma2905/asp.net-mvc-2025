using System.Diagnostics;
using _9ViewToControllerFormCollection.Models;
using Microsoft.AspNetCore.Mvc;

namespace _9ViewToControllerFormCollection.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult ShowData(IFormCollection data)
        {
            ViewBag.sid = data["sid"];
            ViewBag.sname = data["sname"];
            ViewBag.sdob = data["sdob"];
            ViewBag.sgen = data["sgen"];
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
