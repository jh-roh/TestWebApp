using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.DotNetNote.Controllers
{
    public class BasicController : Controller
    {
        public string Index()
        {
            return "Index 액션 메소드";
        }
    }
}
