using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.ViewComponents
{
    public class TechListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var techLists = new List<Tech>()
            {
                new Tech() {Id = 1, Title = "ASP.NET Core"},
                new Tech() {Id = 2, Title = "C#"},
                new Tech() {Id = 3, Title = "Azure"},
                new Tech() {Id = 4, Title = "Database"},
                new Tech() {Id = 5, Title = "Angular"},
                new Tech() {Id = 6, Title = "jQuery"},
            };

            return View(techLists);
        }
    }
}
