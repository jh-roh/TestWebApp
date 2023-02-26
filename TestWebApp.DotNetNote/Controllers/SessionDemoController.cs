﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TestWebApp.DotNetNote.Controllers
{
    public class SessionDemoController : Controller
    {
        public IActionResult Index()
        {
            //[1] 세션 저장
            HttpContext.Session.SetString("UserName", "Green");

            return View();
        }

        public IActionResult GetSession() 
        {
            //[2] 세션 읽기
            ViewBag.UserName = HttpContext.Session.GetString("UserName");

            return View();
        }
        /// <summary>
        /// 세션에 날짜값 저장
        /// </summary>
        /// <returns></returns>
        public IActionResult SetDate()
        {
            //현재 시간을 세션 개체에 저장
            HttpContext.Session.Set<DateTime>("NowDate", DateTime.Now);
            return RedirectToAction("GetDate");
        }
        

        /// <summary>
        /// 세션에 날짜값 읽어오기
        /// </summary>
        /// <returns></returns>
        public IActionResult GetDate() 
        {
            //세션에서 "NowDate"의 값을 읽어오기
            var date = HttpContext.Session.Get<DateTime>("NowDate");
            var sessionTime = date.TimeOfDay.ToString();
            var currentTime = DateTime.Now.TimeOfDay.ToString();

            return Content($"현재 시간 : {currentTime} -" + $"세션에 저장되어 있는 시간 : {sessionTime}");
        }
    }
}
