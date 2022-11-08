using Microsoft.AspNetCore.Mvc;

namespace Ch02_04_FileSender.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string content = "Hello world!!!<br>";
            content += "<a href = \"Home/GetFile\"> Download file </a><br>";
            content += "<a href = \"Home/GetBytes\"> Download byte array </a><br>";
            content += "<a href = \"Home/GetStream\"> Download stream </a><br>";
            content += "<a href = \"Home/GetVirtualFile\"> Download Virtual File </a><br>";
            return new HTMLResult(content);
        }

        public IActionResult GetFile()
        {
            // Путь к файлу
            string file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/Hello.txt");
            // Тип файла - content-type
            string file_type = "text/plain";
            // Имя файла - необязательно
            string file_name = "hello.txt";
            return PhysicalFile(file_path, file_type, file_name);
        }
        public IActionResult GetBytes()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/Hello.txt");
            byte[] mas = System.IO.File.ReadAllBytes(path);
            string file_type = "text/plain";
            string file_name = "hello2.txt";
            return File(mas, file_type, file_name);
        }
        public IActionResult GetStream()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/Hello.txt");
            FileStream fs = new FileStream(path, FileMode.Open);
            string file_type = "text/plain";
            string file_name = "hello3.txt";
            return File(fs, file_type, file_name);
        }
        public IActionResult GetVirtualFile() => File("Files/Hello.txt", "text/plain", "Hello4.txt");
    }
}
