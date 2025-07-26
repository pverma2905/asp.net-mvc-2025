using System.Diagnostics;
using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCProject.Controllers
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
            Student student = new Student()
            {
                roll = 1,
                name = "Akash kumar",
                gender = "Male",
                age = 18,
                course = "Java",
                fee = 7000
            };

            return View(student);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult OurTeam()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Default()
        {
            return View("Index");
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Contact()
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
