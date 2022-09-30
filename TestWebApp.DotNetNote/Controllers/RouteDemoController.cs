using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetNote.Controllers
{
    //[Route()] 특성을 사용한 어트리뷰트 라우팅
    [Route("RouteDemo")]
    public class RouteDemoController : Controller
    {
        [Route("Test"), Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
