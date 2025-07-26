using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiModelPass.Models;

namespace MultiModelPass.Controllers
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

        public IActionResult ShowStudents() {
            List<Student> students = new List<Student>()
            {
                new Student(){ roll = 1, name = "amit kumar", gender="male", course="Java"},
                new Student(){ roll = 2, name = "sneha kumari", gender="female", course="Python" },
                new Student(){ roll = 3, name = "deepika  kumari", gender="female", course="C++" },
                new Student(){ roll = 4, name = "sumit kumar", gender="male", course="C#" }

            };
            return View(students);
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
