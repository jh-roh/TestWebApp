using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWebApp.NoticBoard.DataContext;
using TestWebApp.NoticBoard.Models;
using TestWebApp.NoticBoard.ViewModel;

namespace TestWebApp.NoticBoard.Controllers
{
    public class AccountController : Controller
    {
        private NoticeBoardDbContext _DbContext;

        public AccountController(NoticeBoardDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                //Linq - 메서드 체이닝
                // => : A Go to B
                var user = _DbContext.Users.FirstOrDefault(p => p.UserID.Equals(model.UserID)
                                                             && p.UserPassword.Equals(model.UserPassword));

                if (user != null)
                {
                    //로그인에 성공했을 때
                    //HttpContext.Session.SetInt32(Key, Value)
                    HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                    return RedirectToAction("LoginSuccess", "Home");
                }

                //로그인에 실패했을 때
                ModelState.AddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
            }

            return View(model);
        }


        public IActionResult LogOut()
        {
            //HttpContext.Session.Clear();
            HttpContext.Session.Remove("USER_LOGIN_KEY");

            return RedirectToAction("Index", "Home");
        }


        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>

        public IActionResult Register()
        {
            return View();
          
        }

        /// <summary>
        /// 회원가입 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                _DbContext.Users.Add(model);
                _DbContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
