using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetNote.Controllers
{
    public class RazorDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RazorDemo()
        {
            return View();
        }
    }
}
