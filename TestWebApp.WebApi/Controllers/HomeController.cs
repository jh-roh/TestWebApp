using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using TestWebApp.WebApi.Model;

namespace TestWebApp.WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<Member> _memOpts;

        public HomeController(IOptions<Member> memOpts)
        {
            _memOpts = memOpts;
        }

        public IActionResult Index()
        {
            var opts = _memOpts.Value;

            return View(opts);
        }

        //public IActionResult Login()
        //{
        //    var peopleClaims = new List<Claim>()
        //    {
        //        new Claim(ClaimTypes.Name, "Jack"),
        //        new Claim(ClaimTypes.Email, "Jack@gokulie.com"),
        //        new Claim("Face.Beauty", "Excellent")
        //    };

        //    var licesnseClaims = new List<Claim>()
        //    {
        //        new Claim(ClaimTypes.Name, "Jack Hamilton"),
        //        new Claim("License.Number", "123-456-789"),
        //    };

        //    var peopleIdentity = new ClaimsIdentity(peopleClaims, "People Identity");
        //    var licenseIdentity = new ClaimsIdentity(licesnseClaims, "License Identity");

        //    var userPrincipal = new ClaimsPrincipal(new[] { peopleIdentity, licenseIdentity });

        //    HttpContext.SignInAsync(userPrincipal);

        //    return RedirectToAction("Index");
        //}


        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "testUser"),
                new Claim("Admin", "true")
            };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
