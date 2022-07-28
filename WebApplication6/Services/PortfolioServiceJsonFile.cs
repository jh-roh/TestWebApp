using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TestWebApp.Models;

namespace TestWebApp.Services
{
    public class PortfolioServiceJsonFile
    {
        public IEnumerable<Portfolio> GetPortfolios()
        {
            var jsonFileName = @"C:\Users\jh.roh\source\repos\WebApplication6\WebApplication6\wwwroot\Portfolios\portfolios.json";

            using(var jsonFileReader = File.OpenText(jsonFileName))
            {
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                
                var portfolios = JsonSerializer.Deserialize<Portfolio[]>(jsonFileReader.ReadToEnd(), options);

                return portfolios;
            }
        }




    }
}
