using Microsoft.AspNetCore.Mvc;

namespace Ch02_05_DependancyInjection

{
    public class HomeController : Controller
    {
        readonly ITimeService _timeService;

        public HomeController(ITimeService timeService) 
        { 
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            string content = "Hello world!!! <br>";
            content += $"{_timeService.Time.ToString()}<br>";
            content += "<a href = \"Home/Page1\"> attribute FromServises </a><br>";
            content += "<a href = \"Home/Page2\"> HttpContext.RequestServices.GetService </a><br>";

            return new HTMLResult(content);
        }

        public string Page1([FromServices] ITimeService timeService)
        {
            return timeService.Time.ToString();
        }
        public string Page2()
        {
            ITimeService? timeService = HttpContext.RequestServices.GetService<ITimeService>();
            return timeService?.Time ?? "Undefined";
        }
    }
}
