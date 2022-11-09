var builder = WebApplication.CreateBuilder(args);

// добавл€ем поддержку контроллеров с представлени€ми
builder.Services.AddControllersWithViews();
// внедр€ем сервис ITimeService
var app = builder.Build();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();