using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetSale.Models;

namespace TestWebApp.DotNetSale.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            CategoryRepositoryInMemory repository = new CategoryRepositoryInMemory();

            var categories = repository.GetCategories();

            return View(categories);
        }
    }
}
