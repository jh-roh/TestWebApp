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

        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProductList(int categoryId = 0)
        {
            ViewBag.CategoryId = categoryId;

            return View();
        }

        public IActionResult ProductPage()
        {

            return View();
        }

        [HttpGet]
        public IActionResult ReviewList(int productId = 0)
        {

            ViewData["Product"] = productId;

            return View();


        }

        public IActionResult AddToCart(
            int productId = 0, int quantity = 0)
        {
            ViewBag.ProductId = productId;
            ViewData["Quantity"] = quantity;

            return View();
        }


        [HttpGet]
        public IActionResult ShoppingCart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(
            int productId = 0, int quantity = 0)
        {
            ViewBag.ProductId = productId;
            ViewData["Quantity"] = quantity;
            return View();
        }
        [HttpGet]
        public IActionResult SearchForm()
        {

            return View();

        }

        [HttpPost]
        public IActionResult SearchResult(string modelName)
        {
            ViewBag.ModelName = modelName;

            return View();

        }
    }




}
