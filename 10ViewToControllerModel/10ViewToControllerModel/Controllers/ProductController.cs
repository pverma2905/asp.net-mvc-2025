using _10ViewToControllerModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10ViewToControllerModel.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowData(Product prod)
        {
            ViewBag.Id = prod.prodid;
            ViewBag.Name = prod.prodname;
            ViewBag.Qty = prod.prodqty;
            ViewBag.Price = prod.prodprice;
            return View();

        }
    }
}
