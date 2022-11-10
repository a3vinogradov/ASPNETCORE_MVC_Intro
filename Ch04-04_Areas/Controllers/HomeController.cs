using Microsoft.AspNetCore.Mvc;

namespace Ch04_04_Areas.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => "HomeController вне области";
    }
}
