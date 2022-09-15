using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace TestWebApp.AuthenticationAuthorization
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //컨트롤러 사용 시 서비스의 Controller 미들웨어 추가 필요
            services.AddControllers();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapGet("/", async context =>
                {
                    string content = "<h1>ASP.NET Core 인증과 권한 초간단 코드</h1>";

                    content += $"<a href=\"/Login\">로그인</a>";
                    content += "</br>";
                    content += $"<a href=\"/Login/User\">로그인(User)</a>";
                    content += "</br>";
                    content += $"<a href=\"/Login/Administrator\">로그인(Administartor)</a>";
                    content += "</br>";
                    content += $"<a href=\"/Info\">정보</a>";
                    content += "</br>";
                    content += $"<a href=\"/InfoDetails\">정보(Details)</a>";
                    content += "</br>";
                    content += $"<a href=\"/InfoJson\">정보(Json)</a>";
                    content += "</br>";
                    content += $"<a href=\"/LogOut\">로그아웃</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Landing/Index\">랜딩 페이지</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Greeting/\">환영 페이지</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Dashboard/\">관리 페이지</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/api/AuthService\">로그인 정보(JSON)</a>";

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync(content);
                });

                #region Login
                endpoints.MapGet("/Login", async context =>
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, "아이디")
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    //인증 쿠키 생성
                    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);


                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>로그인 완료</h3>");
                });
                #endregion

                #region /Login/{UserName}
                endpoints.MapGet("/Login/{UserName}", async context =>
                {
                    var username = context.Request.RouteValues["UserName"].ToString();

                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, username),
                        new Claim(ClaimTypes.Name, username),
                        new Claim(ClaimTypes.Email, username + "@a.com"),
                        new Claim(ClaimTypes.Role, "Users"),
                        new Claim("원하는 이름", "원하는 값"),
                    };

                    if(username == "Administrator")
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    //인증 쿠키 생성
                    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                            , claimsPrincipal
                                            , new AuthenticationProperties { IsPersistent = true });


                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>로그인 완료</h3>");
                });
                #endregion



                #region Info
                endpoints.MapGet("/Info", async context =>
                {
                    string result = "";

                    if (context.User.Identity.IsAuthenticated)
                    {
                        result = $"<h3>로그인 이름: {context.User.Identity.Name} </h3>"; 
                    }
                    else
                    {
                        result = "<h3>로그인하지 않았습니다.</h3>";
                    }

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync(result, Encoding.Default);
                });

                #endregion

                #region InfoDetail
                endpoints.MapGet("/InfoDetails", async context =>
                {
                    string result = "";

                    if (context.User.Identity.IsAuthenticated)
                    {
                        result = $"<h3>로그인 이름: {context.User.Identity.Name} </h3>";

                        foreach (var claim in context.User.Claims)
                        {
                            result += $"{claim.Type} = {claim.Value}<br/>";
                        }

                        if (context.User.IsInRole("Administrator") && context.User.IsInRole("Users"))
                        {
                            result += "<br>Administartor + Users 권한이 있습니다.<br/>";
                        }
                    }
                    else
                    {
                        result = "<h3>로그인하지 않았습니다.</h3>";
                    }

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync(result, Encoding.Default);
                });

                #endregion


                #region InfoJson
                endpoints.MapGet("/InfoJson", async context =>

                {
                    string json = "";

                    if (context.User.Identity.IsAuthenticated)
                    {
                        var claims = context.User.Claims.Select(c => new ClaimDto { Type = c.Type, Value = c.Value});
                        
                        json += JsonSerializer.Serialize<IEnumerable<ClaimDto>>(claims,new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping});
                    }
                    else
                    {
                        json = "{}";
                    }
                    //MIME 타입
                    context.Response.Headers["Content-Type"] = "application/json; charset=utf-8";
                    await context.Response.WriteAsync(json, Encoding.Default);
                });

                #endregion

                #region LogOut
                endpoints.MapGet("/LogOut", async context =>
                {
                    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>로그아웃 완료</h3>");
                });

                #endregion

            });
        }

    }

    /// <summary>
    /// Data Transfer Object
    /// </summary>
    public class ClaimDto
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }


    #region MVC Controller
    [AllowAnonymous]
    public class LandingController : Controller
    {
        public IActionResult Index() => Content("누구나 접근 가능");


        [Authorize]
        [Route("/Greeting")]
        public IActionResult Greeting()
        {
            var roleName = HttpContext.User.IsInRole("Administrator") ? "관리자" : "사용자";

            return Content($"<em>{roleName}님 반갑습니다.</em>", "text/html", Encoding.Default);
        }


    }


    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index() => Content("관리자님, 반갑습니다.");

    }
    #endregion


    [ApiController]
    [Route("api/[controller]")]
    public class AuthServiceController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IEnumerable<ClaimDto> Get() =>
            HttpContext.User.Claims.Select(p => new ClaimDto { Type = p.Type, Value = p.Value});





    }
}
