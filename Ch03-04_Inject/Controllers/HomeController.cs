using Microsoft.AspNetCore.Mvc;

namespace Ch03_04_Inject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Внедрение зависимостей в представления";
            return View();
        }
    }
}
