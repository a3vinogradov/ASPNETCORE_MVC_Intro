using Microsoft.AspNetCore.Mvc;

namespace Ch04_03_AttributeRout.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home/Index")]
        [Route("homepage")]
        public IActionResult Index()
        {
            return Content("ASP.NET Core на metanit.com");
        }
        [Route("About")]
        public IActionResult About()
        {
            return Content("About site");
        }

        [Route("{name:minlength(3)}/{age:int}")] // http://localhost:xxxx/tom/37
        public string Person(string name, int age)
        {
            return $"name={name} | age={age}";
        }

        // http://localhost:xxxx/Home/TestPage
        // http://localhost:xxxx/Home/TestPage/9
        [Route("Home/TestPage/{id?}")] 
        public string Test(int? id)
        {
            if (id is not null)
                return $"Параметр id={id}";
            else
                return $"Параметр id неопределен";
        }
    }
}
