using _12StronglyTypedHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace _12StronglyTypedHelper.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Login l = new Login() { userName = "admin", password = "1234" };
            return View(l);
        }
    }
}
