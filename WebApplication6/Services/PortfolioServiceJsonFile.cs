using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public void AddRating(int portfolioId, int rating)
        {
            var portfolios = GetPortfolios();

            if (portfolios.First(p => p.Id == portfolioId).Ratings == null)
            {
                portfolios.First(p => p.Id == portfolioId).Ratings = new int[] { rating };
            }
            else
            {
                var ratings = portfolios.First(p => p.Id == portfolioId).Ratings.ToList();

                ratings.Add(rating);

                portfolios.First(p => p.Id == portfolioId).Ratings = ratings.ToArray();

            }

            using var outputStream = File.OpenWrite(JsonFileName);
            JsonSerializer.Serialize<IEnumerable<Portfolio>>(
                new Utf8JsonWriter(outputStream, new JsonWriterOptions 
                {
                    SkipValidation = true, 
                    Indented = true  }), portfolios);
        }
    }
}
