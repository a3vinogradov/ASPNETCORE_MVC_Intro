using Microsoft.AspNetCore.Mvc;

namespace Ch06_01_HTMLHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
