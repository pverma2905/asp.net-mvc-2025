using System.Diagnostics;
using _8ViewToControllerRequestObject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8ViewToControllerRequestObject.Controllers
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
        public IActionResult ShowData()
        {
            ViewBag.sid = Request.Form["sid"];
            ViewBag.sname = Request.Form["sname"];
            ViewBag.sdob = Request.Form["sdob"];
            ViewBag.sgen = Request.Form["sgen"];
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
