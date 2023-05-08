using Microsoft.AspNetCore.Mvc;

namespace traineePrac.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Example()
        {
            return View();
        }
        public IActionResult ViewBagExample()
        {
            ViewBag.Contents = "this is a content inside a viewbag";
            return View();
        }
        public IActionResult ViewBagExampleWithList()
        {
            List<string> names = new List<string> { "John", "Alice", "Bob" };
            ViewBag.NamesList = names;
            return View();
        
        }

        public IActionResult ViewBagExampleWithObject()
        {
            var obj = new { name=" abc", age = 40 };
            ViewBag.obj = obj;
            return View();

        }

        public IActionResult ViewDataExampleWithObjects()
        {
            var obj = new { name = " abc", age = 40 };
            ViewData["object"] = obj;
            return View();

        }
    }
}
