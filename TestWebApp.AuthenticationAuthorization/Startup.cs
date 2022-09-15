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
            //��Ʈ�ѷ� ��� �� ������ Controller �̵���� �߰� �ʿ�
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
                    string content = "<h1>ASP.NET Core ������ ���� �ʰ��� �ڵ�</h1>";

                    content += $"<a href=\"/Login\">�α���</a>";
                    content += "</br>";
                    content += $"<a href=\"/Login/User\">�α���(User)</a>";
                    content += "</br>";
                    content += $"<a href=\"/Login/Administrator\">�α���(Administartor)</a>";
                    content += "</br>";
                    content += $"<a href=\"/Info\">����</a>";
                    content += "</br>";
                    content += $"<a href=\"/InfoDetails\">����(Details)</a>";
                    content += "</br>";
                    content += $"<a href=\"/InfoJson\">����(Json)</a>";
                    content += "</br>";
                    content += $"<a href=\"/LogOut\">�α׾ƿ�</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Landing/Index\">���� ������</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Greeting/\">ȯ�� ������</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/Dashboard/\">���� ������</a>";
                    content += "</br>";
                    content += $"<hr/><a href=\"/api/AuthService\">�α��� ����(JSON)</a>";

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync(content);
                });

                #region Login
                endpoints.MapGet("/Login", async context =>
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, "���̵�")
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    //���� ��Ű ����
                    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);


                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>�α��� �Ϸ�</h3>");
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
                        new Claim("���ϴ� �̸�", "���ϴ� ��"),
                    };

                    if(username == "Administrator")
                    {
                        claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    //���� ��Ű ����
                    await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                                            , claimsPrincipal
                                            , new AuthenticationProperties { IsPersistent = true });


                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>�α��� �Ϸ�</h3>");
                });
                #endregion



                #region Info
                endpoints.MapGet("/Info", async context =>
                {
                    string result = "";

                    if (context.User.Identity.IsAuthenticated)
                    {
                        result = $"<h3>�α��� �̸�: {context.User.Identity.Name} </h3>"; 
                    }
                    else
                    {
                        result = "<h3>�α������� �ʾҽ��ϴ�.</h3>";
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
                        result = $"<h3>�α��� �̸�: {context.User.Identity.Name} </h3>";

                        foreach (var claim in context.User.Claims)
                        {
                            result += $"{claim.Type} = {claim.Value}<br/>";
                        }

                        if (context.User.IsInRole("Administrator") && context.User.IsInRole("Users"))
                        {
                            result += "<br>Administartor + Users ������ �ֽ��ϴ�.<br/>";
                        }
                    }
                    else
                    {
                        result = "<h3>�α������� �ʾҽ��ϴ�.</h3>";
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
                    //MIME Ÿ��
                    context.Response.Headers["Content-Type"] = "application/json; charset=utf-8";
                    await context.Response.WriteAsync(json, Encoding.Default);
                });

                #endregion

                #region LogOut
                endpoints.MapGet("/LogOut", async context =>
                {
                    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                    context.Response.Headers["Content-Type"] = "text/html; charset=utf-8";
                    await context.Response.WriteAsync("<h3>�α׾ƿ� �Ϸ�</h3>");
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
        public IActionResult Index() => Content("������ ���� ����");


        [Authorize]
        [Route("/Greeting")]
        public IActionResult Greeting()
        {
            var roleName = HttpContext.User.IsInRole("Administrator") ? "������" : "�����";

            return Content($"<em>{roleName}�� �ݰ����ϴ�.</em>", "text/html", Encoding.Default);
        }


    }


    [Authorize(Roles = "Administrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index() => Content("�����ڴ�, �ݰ����ϴ�.");

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
