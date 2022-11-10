using Microsoft.AspNetCore.Mvc;

namespace Ch04_02_DefineRoute.Controllers
{
    public class HomeController : Controller
    {

        public string Index(int id) => $"Index Page. Id: {id}";
        public string About(string name, int age) => $"About Page. Name: {name}  Age: {age}";
        public string Contact(string contact, string info) => $"Contact Page. Contact: {contact}  Info: {info}";

    }
}
