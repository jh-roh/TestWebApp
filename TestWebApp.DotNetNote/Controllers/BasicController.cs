using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestWebApp.DotNetNote.Controllers
{
    /// <summary>
    /// Basic 컨트롤러 클래스
    /// </summary>
    public class BasicController : Controller
    {
        private readonly IConfiguration Configuration;

        public BasicController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Unit()
        {
            string htmlTag = "<h1>테스트 입니다. 안녕하세요</h1>";


            return View((object)htmlTag);
        }

        [HttpGet] //생략 가능

        public IActionResult Quiz(int Id, int Page)
        {
            //액션 메서드의 값을 뷰페이지에 전송
            ViewBag.Page = Page;
            ViewData["Id"] = Id;

            return View();
        }

        [HttpPost]
        public IActionResult Quiz(string answer)
        {
            ViewBag.Answer = answer;
            return View();
        }

        /// <summary>
        /// 강력한 형식(Strongly Typed)의 뷰 페이지
        /// </summary>
        /// <returns></returns>
        public IActionResult Analysis()
        {
            int score = 100;
            return View(score);
        }


        public IActionResult Review()
        {
            return View();
        }
    }
}
