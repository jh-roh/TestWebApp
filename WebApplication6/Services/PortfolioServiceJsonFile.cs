using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TestWebApp.Models;

namespace TestWebApp.Services
{
    public class PortfolioServiceJsonFile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public string JsonFileName {
            get
            {
                //return _webHostEnvironment.WebRootPath + "//Portfolios" + "//portfolios.json";
                return Path.Combine(_webHostEnvironment.WebRootPath , "Portfolios" ,"portfolios.json");
            }
        }

        public PortfolioServiceJsonFile(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }


        public IEnumerable<Portfolio> GetPortfolios()
        {
            //var jsonFileName = @"C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\wwwroot\Portfolios\portfolios.json";

            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                
                var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);

                return portfolios;
            }
        }




    }
}
