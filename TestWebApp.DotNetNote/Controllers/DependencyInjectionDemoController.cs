using Microsoft.AspNetCore.Mvc;
using System;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class DependencyInjectionDemoController : Controller
    {
        private ICopyrightService _svc1;
        private ICopyrightService _svc2;

        public DependencyInjectionDemoController(ICopyrightService service1, ICopyrightService service2)
        {
            _svc1 = service1;
            _svc2 = service2;

        }

        public IActionResult Index()
        {
            //CopyrightService _svc = new CopyrightService();

            ViewBag.Copyright = $"Copyright {DateTime.Now.Year} all right reserved";

            //ViewBag.Copyright = _svc.GetCopyrightString();

            return View();
        }

        public IActionResult About()
        {
            
            //ViewBag.Copyright = $"Copyright {DateTime.Now.Year} all right reserved";

            ViewBag.Copyright = _svc1.GetCopyrightString() + ", " +
                                _svc2.GetCopyrightString();

            return View();
        }

        public IActionResult AtInjectDemo()
        {
            return View();
        }
    }
}
