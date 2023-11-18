#region Roots
using Microsoft.AspNetCore.Mvc.Razor;
using Newtonsoft.Json.Serialization;
using SmartEducation.DataAccess;
using SmartEducation.Service;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseWebRoot(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
builder.Logging.AddJsonConsole();
#endregion

#region ProjectCommonSetUp


builder.Services.AddRazorPages();
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
});



builder.Services.AddMvc().AddNewtonsoftJson(options =>
options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver =new CamelCasePropertyNamesContractResolver());
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.AddHttpContextAccessor();

builder.Services.AddMvc().AddRazorPagesOptions(options =>
{
    options.Conventions.AddAreaPageRoute("Identity", "/Auth/Authentication/Login", "");
});

//builder.Services.AddMvc(options =>
//{
//    options.MaxModelBindingCollectionSize = 100000;
//});
//builder.Services.Configure<FormOptions>(options =>
//{
//    options.ValueCountLimit = int.MaxValue;
//    options.ValueLengthLimit = int.MaxValue;
//    options.MultipartHeadersLengthLimit = int.MaxValue;
//});

builder.Services.AddDistributedMemoryCache(); // Add a distributed memory cache
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".MyApp.Session";
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

//builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


#endregion

#region Areas Config
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Areas/{2}/{0}" + RazorViewEngine.ViewExtension);
    options.AreaViewLocationFormats.Add("/areas/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/areas/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
    // {0} - Action Name
    // {1} - Controller Name
    // {2} - Area Name
});


#endregion

//#region Config_CustomServices
builder.Services.AddSmartEducationDataAccessServices(builder.Configuration);
builder.Services.AddSmartEducationServices();
//#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();
app.UseSession();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

//ILogger logger = app.Logger;
//IHostApplicationLifetime lifetime = app.Lifetime;
//IWebHostEnvironment env = app.Environment;
app.MapRazorPages();

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
