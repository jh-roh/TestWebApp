using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace TestWebApp.DotNetNote.Controllers
{
    public class AppSettingDemoController : Controller
    {
        private readonly IConfiguration _configuration;

        public AppSettingDemoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var con1 =  _configuration.GetSection("StorageConnectionString").Value;
            var con2 = _configuration.GetSection("BlobStorageConnectionString")
                                     .GetSection("Site1").Value;

            var site2 = _configuration
                        .GetValue<string>("BlobStorageConnectionString:Site2");

            return Content($"{con1}, {con2}, {site2}");
        }
    }
}
