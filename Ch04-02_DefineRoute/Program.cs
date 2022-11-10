var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ������������ � ���������������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������������� ������������� ��������� � �������������
app.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id}"); // 1 �������� � �������
app.MapControllerRoute(name: "name_age", pattern: "{controller}/{action}/{name}/{age}"); // 2 ��������� � �������
app.MapControllerRoute(name: "route1", pattern: "api/{controller}/{action}/{id}"); // ����������� ������� ������� api
app.MapControllerRoute(name: "route2", pattern: "{controller=Home}/{action=Index}/{id?}"); // 1 �� ������������ �������� id? � ��������� �� ���������
// �������������� ������� ������� ���������� �� ���������
app.MapControllerRoute(
    name: "default",
    pattern: "api/{action}",
    defaults: new { controller = "Home", action = "About" }); 
app.Run();
