using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Note.BLL;
using Note.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Note.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserBll _userBll;

        private readonly ILogger<HomeController> _logger;

        public HomeController(UserBll userBll, ILogger<HomeController> logger)
        {
            _logger = logger;
            _userBll = userBll;
        }

        public IActionResult Index()
        {
            var user = _userBll.GetUser(1);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
