//[User][6]
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TestWebApp.DotNetNote.Common;
using TestWebApp.DotNetNote.Components;
using TestWebApp.DotNetNote.Models.User;

namespace DotNetNote.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository )
        {
            _repository = repository;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();  
        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("UserID", "아이디를 입력하시오.....");
            }
            else
            {
                _repository.AddUser(model.UserID, model.Password);

                return RedirectToAction("Index");

            }

            return View();
        }

        [AllowAnonymous] //인증되지 않은 사용자도 접근 가능
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserViewModel model, string returnUrl = null)
        {
            if(ModelState.IsValid)
            {
                //쿠키 인증 공식 코드가 들어오는 곳
                if(true)
                //if(_repository.IsCorrectUser(model.UserID, model.Password)) 
                {
                    //[!] 인증 부여

                    var claims = new List<Claim>()
                    {
                        new Claim("UserID", model.UserID),
                    };

                    var ci = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(ci);

                    var authenticationProperties = new AuthenticationProperties()
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20),
                        IssuedUtc = DateTimeOffset.UtcNow,
                        IsPersistent = false
                    };


                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                }

                return RedirectToAction("Index","User");
            }

            ViewData["ReturnUrl"] = returnUrl;


            return View(model);
        }

        public IActionResult Logout() 
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return View();
        }


        //[User][6][8] : 회원 정보 보기 및 수정
        [Authorize]
        public IActionResult UserInfo()
        {

            return View();
        }



        ////[User][6][1]
        //private IUserRepository _repository;
        //private ILoginFailedManager _loginFailed;
        //private IUserModelRepository _userRepo;

        //public UserController(
        //    IUserRepository repository,
        //    ILoginFailedManager loginFailed,
        //    IUserModelRepository userRepo)
        //{
        //    _repository = repository;
        //    _loginFailed = loginFailed;
        //    _userRepo = userRepo; // 추가 
        //}

        ////[User][6][2]
        //[Authorize]
        //public IActionResult Index() => View();

        ////[User][6][3] : 회원 가입 폼
        //[HttpGet]
        //public IActionResult Register() => View();

        ////[User][6][4] : 회원 가입 처리
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Register(UserViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (_repository.GetUserByUserID(model.UserID).UserID != null)
        //        {
        //            ModelState.AddModelError("", "이미 가입된 사용자입니다.");
        //            return View(model);
        //        }
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "잘못된 가입 시도!!!");
        //        return View(model);
        //    }
        //    else
        //    {
        //        //_repository.AddUser(model.UserId, model.Password);
        //        _repository.AddUser(model.UserID, (new Dul.Security.CryptorEngine()).EncryptPassword(model.Password)
        //        );
        //        return RedirectToAction("Index");
        //    }
        //}

        ////[User][6][5] : 로그인 폼
        //[HttpGet]
        //[AllowAnonymous] // 인증되지 않은 사용자도 접근 가능
        //public IActionResult Login(string returnUrl = null)
        //{
        //    ViewData["ReturnUrl"] = returnUrl;
        //    return View();
        //}

        ////[User][6][6] : 로그인 처리
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login(
        //    UserViewModel model, string returnUrl = null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //[!] 로그인 실패 5번 체크
        //        if (_loginFailed.IsLoginFailed(model.UserID))
        //        {
        //            ViewBag.IsLoginFailed = true;
        //            return View(model);
        //        }

        //        //if (_repository.IsCorrectUser(model.UserId, model.Password))
        //        if (_repository.IsCorrectUser(model.UserID, (new Dul.Security.CryptorEngine()).EncryptPassword(model.Password)))
        //        {
        //            //[!] 인증 부여: 인증된 사용자의 주요 정보(Name, Role, ...)를 기록
        //            var claims = new List<Claim>()
        //            {
        //                // 로그인 아이디 지정
        //                new Claim("UserID", model.UserID),

        //                new Claim(ClaimTypes.NameIdentifier, model.UserID),

        //                new Claim(ClaimTypes.Name, model.UserID), 
        //                //new Claim(ClaimTypes.Email, model.UserId), //

        //                // 기본 역할 지정, "Role" 기능에 "Users" 값 부여
        //                new Claim(ClaimTypes.Role, "Users") // 추가 정보 기록
        //            };

        //            //var ci = new ClaimsIdentity(claims, (new Dul.Security.CryptorEngine()).EncryptPassword(model.Password));
        //            var ci = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        //            //[1] 로그인 처리: Authorize 특성 사용해서 로그인 체크 가능 
        //            //[1][1] ASP.NET Core 1.X 사용: 버전업되면서 아래 메서드 사용 중지 
        //            //await HttpContext.Authentication.SignInAsync(
        //            //    "Cookies", new ClaimsPrincipal(ci));
        //            //[1][2] ASP.NET Core 2.X 사용
        //            var authenticationProperties = new AuthenticationProperties()
        //            {
        //                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
        //                IssuedUtc = DateTimeOffset.UtcNow,
        //                IsPersistent = true
        //            };
        //            //await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(ci), new AuthenticationProperties { IsPersistent = true });
        //            //await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(ci), authenticationProperties);
        //            //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ci)); // 기본
        //            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
        //                , new ClaimsPrincipal(ci), authenticationProperties); // 옵션


        //            ////[참고] ASP.NET Core Identity에서 로그인하는 모양
        //            //var identity = new ClaimsIdentity("Cookies");
        //            //identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
        //            //identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

        //            //await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(identity));



        //            // 추가: 세션에 로그인 사용자 정보 저장
        //            // 세션 인증 로그인
        //            //HttpContext.Session.SetString("Username", model.UserId);


        //            return LocalRedirect("/User/Index");
        //        }
        //    }

        //    return View(model);
        //}

        ////[User][6][7]: 로그아웃 처리
        //public async Task<IActionResult> Logout()
        //{
        //    #region Old Version
        //    // Startup.cs의 미들웨어에서 지정한 "Cookies" 이름 사용
        //    // ASP.NET Core 1.X
        //    //await HttpContext.Authentication.SignOutAsync("Cookies");
        //    // ASP.NET Core 2.X
        //    //await HttpContext.SignOutAsync("Cookies"); 
        //    #endregion

        //    //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // 쿠키 인증 로그아웃
        //    await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme); // 토큰 인증 로그아웃 
        //    //HttpContext.Session.Clear(); // 세션 인증 로그아웃

        //    return Redirect("/User/Index");
        //}

        ////[User][6][8] : 회원 정보 보기 및 수정
        //[Authorize]
        //public IActionResult UserInfor() => View();

        ////[User][6][9] : 인사말 페이지
        //public IActionResult Greetings()
        //{
        //    //[Authorize] 특성의 또 다른 표현 방법
        //    // 인증되지 않은 사용자는
        //    if (User.Identity.IsAuthenticated == false)
        //    {
        //        // 로그인 페이지로 리디렉션
        //        return new ChallengeResult();
        //    }

        //    return View();
        //}

        ////[User][6][10] : 접근 거부 페이지
        //public IActionResult Forbidden() => View();

        ////[!] 추가: 사용자 상세 보기(GetUsers 저장 프로시저 사용)
        //[Authorize]
        //public IActionResult UserDetail()
        //{
        //    string userId = User.FindFirst("UserId").Value;
        //    var user = _repository.GetUserByUserID(userId);

        //    //var userModel = _userRepo.GetUserInfor(user.Id); // 캐싱 적용 전
        //    var userModel = _userRepo.GetUserInforCache(user.Id); // 캐싱 적용 후

        //    return View(userModel);
        //}

        ///// <summary>
        ///// 아이디 중복 확인 Web API 테스트
        ///// </summary>
        //public IActionResult CheckUsername() => View();
    }
}
