using Microsoft.AspNetCore.Mvc;

namespace Ch04_01_Route.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            return $"controller: {controller} | action: {action}";
        }
    }
}
