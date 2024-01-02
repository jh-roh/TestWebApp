using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApp.DotNetNote.Common;
using TestWebApp.DotNetNote.Data;
using TestWebApp.DotNetNote.Models;
using TestWebApp.DotNetNote.Models.User;
using System.Resources;
using Humanizer.Localisation;
using TestWebApp.DotNetNote.Resources;

namespace TestWebApp.DotNetNote
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddControllersWithViews(); //MVC + Web API 사용 가능

            services.AddRazorPages(); // Razor Page 사용 가능
            services.AddServerSideBlazor(); // Blazoe Server 사용 가능


            //ResourceManager DI 컨테이너에 등록
            services.AddSingleton<ResourceManager>(provider =>
            {
                return new ResourceManager(typeof(Resource));
            });

            //DI 컨테이너에 등록
            services.AddTransient<ICategoryRepository, CategoryRepositoryInMemory>();

            //[DI] InfoService 클래스 의존성 주입
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService ,InfoService>();

            //[DI](Dependency Injection)] 서비스 등록
            services.AddTransient<ICopyrightService,CopyrightService>();

            //[DI] @inject 키워드로 뷰에 직접 클래스의 속성 또는 메서드 값 출력
            services.AddSingleton<CopyrightService>();


            services.AddTransient<IVariableRepositoryInMemory, VariableRepositoryInMemory>();

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IUserRepository, UserRepository>();


            services.AddTransient<ILoginFailedRepository, LoginFailedRepository>();

            //쿠키 사용 시 선언 필요
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/User/Login";
                        options.LogoutPath = "/User/Logout";
                    });

            services.AddSession(options =>
            {
                options.IdleTimeout= TimeSpan.FromMinutes(5);
            });
        }


        /// <summary>
        /// 의존성 주입 관련 코드만 따로 모아서 관리
        /// - 리포지토리 등록
        /// </summary>
        /// <param name="services"></param>
        private void DependencyInjectionContainer(IServiceCollection services)
        {
            //[?] ConfigurationServices 가 호출되기 전에는 DI(종속성 주입) 가 설정되지 않습니다.

            //Configuration 개체 주입:
            // IConfiguration 또는 IConfigurationRoot에 Configuration 개체 전달
            // appsettings.json 파일의 데이터베이스 연결 문자열을
            // 리포지토리 클래스에서 사용할 수 있도록 설정
            // IConfiguration 주입 -> Configuration의 인스턴스를 실행

            services.AddSingleton<IConfiguration>(Configuration);

            //회원관리
            services.AddTransient<IUserRepository, UserRepository>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession(); //세션 개체 사용, 반드시 UseEndpoints 이전에 호출되어야 함.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //Blazor Server 사용 가능
                endpoints.MapBlazorHub();
                

                endpoints.MapRazorPages();
            });
        }
    }
}
