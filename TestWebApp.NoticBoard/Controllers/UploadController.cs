using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Threading.Tasks;

namespace TestWebApp.NoticBoard.Controllers
{
    public class UploadController : Controller
    {
        private readonly IHostingEnvironment _environment;

        public UploadController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // http://www,example.com/Upload/ImageUpload
        // 라우트 재정의
        [HttpPost, Route("api/upload")]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {

            //#이미지나 파일을 업로드 할 때 필요한 구성
            //1. Path(경로) - 어디에다 저장할지 결정
            var path = Path.Combine(_environment.WebRootPath, @"images\upload");

            //2. Name(이름) - DateTime, Guid(전역 고유 식별자)
            //3. Extension(확장자) - jpg, png... txt
            //파일 이름 image.jpg
            var fileFullName = file.FileName.Split('.');
            var fileName = $"{Guid.NewGuid()}.{fileFullName[1]}";

            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }


            return Ok(new { file="/images/upload/" + fileName, success = true });

            // #URL 접근 방식
            // ASP.NET - 호스트명/api/upload
            // JavaScript - 호스트명 + api/upload => http://www.example.comapi/upload
            // JavaScript - 호스트명 + / + api/upload => http://www.example.com/api/upload
        }
    }
}
