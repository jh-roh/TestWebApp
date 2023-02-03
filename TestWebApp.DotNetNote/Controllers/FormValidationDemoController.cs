using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class FormValidationDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region HTML
        public IActionResult Html()
        {
            return View();
        }

        public IActionResult HtmlProcess(string txtName, string txtContent)
        {
            //var r = $"이름 : {txtName}, 내용 : {txtContent}";
            //var r = $"이름 : {txtName}, 내용 : {Request.Form["txtContent"]}";
            ViewBag.ResultString = $"이름 : {txtName}, 내용 : {Request.Form["txtContent"]}";
            return View();
        }

        #endregion


        /*
         [HttpGet],
         [HttpPost],
         [HttpPut],
         [HttpDelete],
         [HttpPatch]
         
         */


        #region HelperMethod
        [HttpGet]
        public IActionResult HelperMethod()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HelperMethod(string txtName, string txtContent)
        {
            ViewBag.ResultString = $"이름 : {txtName}, 내용 : {Request.Form["txtContent"]}";
            return View();
        }

        #endregion


        #region Strongly Type View + Model Binding

        public IActionResult StronglyTypeView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypeView(MaximModel model)
        {
            return View(model);
        }

        #endregion



        #region Model Validation + Server Validation
        public IActionResult ModelValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModelValidation(MaximModel model)
        {
            //직접 유효성 검사
            if (string.IsNullOrEmpty(model.Name))
            {
                ModelState.AddModelError("Name", "이름을 입력하세요.");
            }

            if (string.IsNullOrEmpty(model.Content))
            {
                ModelState.AddModelError("Name", "내용을 입력하세요.");
            }

            //넘겨온 모델에 대한 유효성 검사
            if (ModelState.IsValid)
            {
                return View("Completed");
            }

            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }
        #endregion


        #region Client Validation

        public IActionResult ClientValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClientValidation(MaximModel model)
        {
            //넘겨온 모델에 대한 유효성 검사
            if (ModelState.IsValid)
            {
                return View("Completed");
            }

            return View();
        }
        #endregion


        #region TagHelper

        public IActionResult TagHelperValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TagHelperValidation(MaximModel model)
        {
            //넘겨온 모델에 대한 유효성 검사
            if (ModelState.IsValid)
            {
                return View("Completed");
            }

            return View();
        }
        #endregion


        #region 태그 헬퍼 사용 폼 유효성 검사 진행하기

        [HttpGet]
        public IActionResult ApplicationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ApplicationForm(Applicant applicant)
        {
            //넘겨온 모델에 대한 유효성 검사
            if(ModelState.IsValid)
            {
                //유효성 검사를 통과하면 DB에 관련 정보 저장
                return View("Completed");
            }

            return View();
        }

        #endregion






    }
}
