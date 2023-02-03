using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class HelperMethodDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult FormDemo()
        {
            return View();
        }

        public IActionResult InputDemo()
        {
            return View();
        }

        public IActionResult SelectDemo()
        {
            return View();
        }
        
        /// <summary>
        /// 강력한 형식의 뷰 ㅣ 특정 모델 클래스가 사용되는 뷰
        /// </summary>
        /// <returns></returns>
        public IActionResult StronglyTypesDemo()
        {
            DataClass dataClass = new DataClass();

            dataClass.Id = 1;
            dataClass.Name = "홍길동";
            dataClass.Title = "홍길동전";

            return View(dataClass);
        }


    }
}
