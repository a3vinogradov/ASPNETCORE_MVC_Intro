using Microsoft.AspNetCore.Mvc;

namespace Ch03_06_Engine.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View("About");
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
