using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class PartialViewDemoController : Controller
    {
        public IActionResult Index(int Page = 1)
        {
            var pageModel = new PagerBase
            {
                Url = "PartialViewDemo",
                RecordCount = 6600,
                PageSize = 10,
                //PageCount = 10,
                PageNumber = Page,

                SearchMode = true,
                SearchField = "Title",
                SearchQuery = "ASP.NET"

            };

            ViewBag.PageModel = pageModel;

            return View();
        }
    }
}
