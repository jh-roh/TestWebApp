using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using TestWebApp.Models;
using TestWebApp.Services;

namespace TestWebApp.Pages.Portfolios
{
    public class DetailsModel : PageModel
    {
        private readonly PortfolioServiceJsonFile _service;

        public IEnumerable<Portfolio> Portfolios { get; private set; }

        public DetailsModel(PortfolioServiceJsonFile service)
        {
            this._service = service;
        }


        public void OnGet()
        {
            Portfolios = _service.GetPortfolios();
        }
    }
}
