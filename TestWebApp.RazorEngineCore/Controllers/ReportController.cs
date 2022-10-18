using Microsoft.AspNetCore.Mvc;
using DevExtreme.AspNet.Data;
using RazorEngineCore;

namespace TestWebApp.RazorEngineCore.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult CustomizedLayout()
        {
            //테스트 한 결과
            //1. ViewTagHelper 지원 안됨.
            //2. HTMLHelper 지원 안됨(Devexpress 사용하려면 HTMLHelper 지원 필요)
            //3. https://github.com/adoconnection/RazorEngineCore .net 5.0 이상 지원 dll
            //4. Model, dll Load 기능, 

            IRazorEngine razorEngine = new RazorEngine();

            string customizedReportNavBar = System.IO.File.ReadAllText("wwwroot/CustomizedReport/Customized_NavBar.cshtml");

            IRazorEngineCompiledTemplate template = razorEngine.Compile(customizedReportNavBar);

            string result = template.Run();

            return View((object)result);
        }

        public IActionResult CustomizedMainBody()
        {

            return View();
        }

     
    }
}
