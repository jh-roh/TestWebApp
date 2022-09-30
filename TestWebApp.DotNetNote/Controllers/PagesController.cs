using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetNote.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route()] 특성을 사용한 어트리뷰트 라우팅
        [Route("404")]
        public IActionResult NotFound()
        {
            return View();
        }

        [Route("NotAssign")]
        public IActionResult NotAssigned()
        {
            return View();
        }
    }
}
