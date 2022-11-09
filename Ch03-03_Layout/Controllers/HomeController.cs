using Microsoft.AspNetCore.Mvc;

namespace Ch03_03_Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Person() => View();
        public IActionResult Hello()
        {
            return PartialView();
        }

    }
}
