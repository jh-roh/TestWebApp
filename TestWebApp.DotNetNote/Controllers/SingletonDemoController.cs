﻿using Microsoft.AspNetCore.Mvc;
using TestWebApp.DotNetNote.Models;

namespace TestWebApp.DotNetNote.Controllers
{
    public class SingletonDemoController : Controller
    {
        ///// <summary>
        ///// [1] 생성자에 클래스 주입
        ///// </summary>
        //private readonly InfoService _svc;

        //public SingletonDemoController(InfoService svc)
        //{
        //    _svc = svc;

        //}


        /// <summary>
        /// [2] 생성자에 인터페이스 주입
        /// </summary>
        private readonly IInfoService _svc;

        public SingletonDemoController(IInfoService svc)
        {
            _svc = svc;

        }

        public IActionResult ConstructionInjectionDemo()
        {
            //클래스와 클래스간의 결합도를 낮추어야 한다.
            //InfoService svc = new InfoService();

            ViewData["Url"] = _svc.GetUrl();

            return View("Index");
        }
        public IActionResult Index()
        {
            ViewData["Url"] = "www.gilbut.co.kr";
            return View();
        }


        public IActionResult InfoServiceDemo()
        {
            
            InfoService svc = new InfoService();

            ViewData["Url"] = _svc.GetUrl();

            return View("Index");
        }
    }
}
