using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetSale.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction(nameof(CategoryList));
        }

        public IActionResult CategoryAdd()
        {
            return View();
        }

        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
