using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult ViewBagDemo()
        {
            ViewBag.Name = "노준호";
            ViewBag.Age = 21;
            ViewBag.원하는모든단어 = "모든 값...";

            ViewData["Address"] = "세종시";
            //ViewBag.Address = "세종시";
              
            return View();
        }

        public IActionResult ViewWithModelDemo()
        {
            DemoModel model = new DemoModel();
            model.Id = 1;
            model.Name = "홍길동";

            return View(model);
        }

        public IActionResult ViewWithListOfDemo()
        {
            List<DemoModel> demoModels = new List<DemoModel>() { 
                new DemoModel()
                {
                    Id = 1,
                    Name = "홍길동"
                },
                new DemoModel()
                {
                    Id = 2,
                    Name = "백두산"
                },
                new DemoModel()
                {
                    Id = 3,
                    Name = "임꺽정"
                },
            };

            return View(demoModels);

        }
    }
}
