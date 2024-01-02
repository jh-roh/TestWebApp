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


            services.AddControllersWithViews(); //MVC + Web API ��� ����

            services.AddRazorPages(); // Razor Page ��� ����
            services.AddServerSideBlazor(); // Blazoe Server ��� ����


            //ResourceManager DI �����̳ʿ� ���
            services.AddSingleton<ResourceManager>(provider =>
            {
                return new ResourceManager(typeof(Resource));
            });

            //DI �����̳ʿ� ���
            services.AddTransient<ICategoryRepository, CategoryRepositoryInMemory>();

            //[DI] InfoService Ŭ���� ������ ����
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService ,InfoService>();

            //[DI](Dependency Injection)] ���� ���
            services.AddTransient<ICopyrightService,CopyrightService>();

            //[DI] @inject Ű����� �信 ���� Ŭ������ �Ӽ� �Ǵ� �޼��� �� ���
            services.AddSingleton<CopyrightService>();


            services.AddTransient<IVariableRepositoryInMemory, VariableRepositoryInMemory>();

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IUserRepository, UserRepository>();


            services.AddTransient<ILoginFailedRepository, LoginFailedRepository>();

            //��Ű ��� �� ���� �ʿ�
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
        /// ������ ���� ���� �ڵ常 ���� ��Ƽ� ����
        /// - �������丮 ���
        /// </summary>
        /// <param name="services"></param>
        private void DependencyInjectionContainer(IServiceCollection services)
        {
            //[?] ConfigurationServices �� ȣ��Ǳ� ������ DI(���Ӽ� ����) �� �������� �ʽ��ϴ�.

            //Configuration ��ü ����:
            // IConfiguration �Ǵ� IConfigurationRoot�� Configuration ��ü ����
            // appsettings.json ������ �����ͺ��̽� ���� ���ڿ���
            // �������丮 Ŭ�������� ����� �� �ֵ��� ����
            // IConfiguration ���� -> Configuration�� �ν��Ͻ��� ����

            services.AddSingleton<IConfiguration>(Configuration);

            //ȸ������
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

            app.UseSession(); //���� ��ü ���, �ݵ�� UseEndpoints ������ ȣ��Ǿ�� ��.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //Blazor Server ��� ����
                endpoints.MapBlazorHub();
                

                endpoints.MapRazorPages();
            });
        }
    }
}
