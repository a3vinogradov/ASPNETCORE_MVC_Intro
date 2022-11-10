var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������� ��� ������� account
app.MapAreaControllerRoute(
    name: "account_area",
    areaName: "account",
    pattern: "profile/{controller=Home}/{action=Index}/{id?}");

// ��������� ��������� ������������, ������� ������������� � �������
app.MapControllerRoute(
    name: "Account",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// ��������� ��������� ��� ������������, ������� ������������� ��� �������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
