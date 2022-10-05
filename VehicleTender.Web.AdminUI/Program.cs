using VehicleTender.Web.AdminUI.ApiServices.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IBaseApiService<Task>, BaseApiService<Task>>();

builder.Services.AddHttpClient<BaseApiService<Task>>(options =>
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Deneme}/{action=IndividualVehiclePurchaseListing}/{id?}");

app.Run();
