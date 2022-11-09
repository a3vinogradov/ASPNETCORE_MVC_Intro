using Microsoft.AspNetCore.Mvc;

namespace Ch03_02_DataParameters.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello METANIT.COM";
            return View();
        }
        public IActionResult Page1()
        {
            ViewData["Message"] = "Hello METANIT.COM";
            return View();
        }
        public IActionResult Page2()
        {
            ViewBag.Message = "Hello METANIT.COM";
            ViewBag.People = new List<string> { "Tom", "Sam", "Bob" };
            return View();
        }
        public IActionResult Page3()
        {
            var people = new List<string> { "Tom", "Sam", "Bob" };
            return View(people);
        }
    }
}
