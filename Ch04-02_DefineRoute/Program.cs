var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров с представлениями
builder.Services.AddControllersWithViews();

var app = builder.Build();

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id}"); // 1 параметр в запросе
app.MapControllerRoute(name: "name_age", pattern: "{controller}/{action}/{name}/{age}"); // 2 параметра в запросе
app.MapControllerRoute(name: "route1", pattern: "api/{controller}/{action}/{id}"); // статическйи сегмент запроса api
app.MapControllerRoute(name: "route2", pattern: "{controller=Home}/{action=Index}/{id?}"); // 1 не обязательный параметр id? и параметры по умолчанию
// альтернативный вариант задания параметров по умолчанию
app.MapControllerRoute(
    name: "default",
    pattern: "api/{action}",
    defaults: new { controller = "Home", action = "About" }); 
app.Run();
