using Microsoft.AspNetCore.Mvc;

namespace Ch03_05_Form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
        [HttpPost]
        public string Index(string username) => $"User Name: {username}";

        public IActionResult UserForm()
        {
            ViewBag.Title = "METANIT.COM";
            return View();
        }
        public IActionResult UserFormHandler(string username, string password, int age, string comment, bool isMarried, string color, string language, string[] languages)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            ViewBag.Age = age;
            ViewBag.Comment = comment;
            ViewBag.IsMarried = isMarried;
            ViewBag.Color = color;
            ViewBag.Language = language;
            ViewBag.Languages = languages;
            return View();
        }
    }
}
