using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetNote.Controllers
{
    public class ViewComponentDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// TechListViewComponent 사용 데모
        /// </summary>
        /// <returns></returns>
        public IActionResult TechListDemo()
        {
            return View();
        }
    }
}
