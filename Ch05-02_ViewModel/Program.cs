var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapControllerRoute
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");

app.Run();
