using Microsoft.AspNetCore.Mvc;

namespace Ch04_03_AttributeRout.Controllers
{
    [Route("dictionary")]
    public class DictionaryController : Controller
    {
 
        [Route("get/{name}")] // https://localhost:7098/dictionary/Get/store
        public string Get(string name) => name;

        [Route("{id:int}/{name:maxlength(10)}")] //https://localhost:7098/dictionary/1/store
        public string Test(int id, string name) => $" id={id} | name={name}";
    }
}
