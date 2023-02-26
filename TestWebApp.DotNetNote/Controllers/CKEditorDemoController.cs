using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;

namespace TestWebApp.DotNetNote.Controllers
{
    public class CKEditorDemoController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public CKEditorDemoController(IWebHostEnvironment environment)
        {
            _environment = environment;
                
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CKEditorDemo(string editor)
        {
            ViewBag.EditorText = editor;

            return View();
        }

        public IActionResult PostWrite()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostWrite(string title, string editor)
        {
            ViewBag.EditorText = $"{title}<hr />{editor}";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(
            ICollection<IFormFile> upload,
            string CKEditorFuncNum,
            string CKEditor,
            string langCode)
        {
            string imgPath = "";
            string msg = "";
            string uploadFolder = Path.Combine(_environment.WebRootPath, "files");


            try
            {
                foreach(var file in upload)
                {
                    if(file != null && file.Length > 0)
                    {
                        var fileName = Path.GetFileName(
                            DateTime.Now.ToString("yyyyMMdd-HHMMssff") + "-"
                            + ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"'));



                        using (var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                        }

                        imgPath = Url.Content("/files/" + fileName);

                        msg = "이미지가 정상적으로 업로드 되었습니다.";
                    }

                }
            }
            catch(Exception ex)
            {
                msg = "오류가 발생햇습니다. 오류 메시지: " + ex.Message;
            }

            string r = $"<script>window.parent.CKEDITOR.tools.callFunction({CKEditorFuncNum}, \"{imgPath}\", \"{msg}\");</script>";


            return Content(r, "text/html");
        }
    }
}
