using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetSale.Controllers
{
    public class DotNetSaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryAdd()
        {
            return View();
        }

        public IActionResult CategoryList()
        {
            return View();
        }

        public IActionResult ProductAdd()
        {
            return View();
        }
    }
}
