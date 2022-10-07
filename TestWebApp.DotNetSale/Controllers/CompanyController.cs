using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetSale.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
