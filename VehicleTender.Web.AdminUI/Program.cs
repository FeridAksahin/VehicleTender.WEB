using VehicleTender.Web.AdminUI.ApiServices.Base;
using NLog;
using NLog.Web;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Logging.ClearProviders();
builder.Host.UseNLog();

//builder.Services.AddScoped<IBaseApiService, BaseApiService>();

builder.Services.AddHttpClient<BaseApiService>(options =>
{
    options.BaseAddress = new Uri(builder.Configuration["apiAddress"]);
});
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

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>endpoints.MapDefaultControllerRoute());
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=UserOperations}/{action=UserList}/{id?}");

app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}