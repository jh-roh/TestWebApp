using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using TestWepApp.BlazorApp.Areas.Identity;
using TestWepApp.BlazorApp.Data;
using TestWepApp.BlazorApp.Models.Candidates;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//���ο� DBContext �߰�
//builder.Services.AddDbContext<CandidateAppDbContext>(options =>  
//    options.UseSqlServer(connectionString));

builder.Services.AddDbContextFactory<CandidateAppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//MVC�� ����ϱ����� �ڵ����� �߰�(Ȯ��޼���)
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<ConfigTable>();
builder.Services.AddScoped<TableCell>();

builder.Services.AddSingleton<IProductService, HardCodedProductsService>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    await CheckCandidateDbMigrated(app.Services);
    CandidateSeedData(app);
    CandidateDbinitializer.Initialize(app);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

//MVC�� ����ϱ����� �ڵ����� �߰�
app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


app.Run();


#region CandidateSeedData : Candidates ���̺� �⺻ ������ �Է�
// Candidates ���̺� �⺻ ������ �Է�
static void CandidateSeedData(WebApplication app)
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var services = serviceScope.ServiceProvider;

        services.GetRequiredService<CandidateAppDbContext>();

        var candidateDbContext = services.GetRequiredService<CandidateAppDbContext>();

        if (!candidateDbContext.Candidates.Any())
        {
            candidateDbContext.Candidates.Add(new Candidate { FirstName = "�浿", LastName = "ȫ", IsEnrollment = false });
            candidateDbContext.Candidates.Add(new Candidate { FirstName = "�λ�", LastName = "��", IsEnrollment = false });
            candidateDbContext.SaveChanges();
        }
    }
}
#endregion


#region CheckCandidateDbMigrated : �����ͺ��̽� ���̱׷��̼� ����
// �����ͺ��̽� ���̱׷��̼� ����
async Task CheckCandidateDbMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var candidateContext = scope.ServiceProvider.GetService<CandidateAppDbContext>();
    using var applicationContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

    if (applicationContext is not null)
    {
        await applicationContext.Database.MigrateAsync();
    }

    if (candidateContext is not null)
    {
        await candidateContext.Database.MigrateAsync();
    }


} 
#endregion
