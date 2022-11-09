using Microsoft.AspNetCore.Mvc;

namespace Ch03_01_ViewIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Page1()
        {
            return View("About");
        }
        public IActionResult Time()
        {
            return View();
        }

    }
}
