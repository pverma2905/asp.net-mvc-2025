using System.Diagnostics;
using _7ViewToControllerUsingParameter.Models;
using Microsoft.AspNetCore.Mvc;

namespace _7ViewToControllerUsingParameter.Controllers
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

        public IActionResult MyForm()
        {
            return View();
        }

        public IActionResult ShowData(String name, string gender, string age)
        {
            ViewBag.Name = name;
            ViewBag.Gender = gender;
            ViewBag.Age = age;
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
