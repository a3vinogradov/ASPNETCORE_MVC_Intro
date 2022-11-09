using Ch03_06_Engine.Util;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ������������ � ���������������
builder.Services.AddControllersWithViews();

// ������������� ������ �������������
builder.Services.Configure<MvcViewOptions>(options => {
    options.ViewEngines.Clear();
    options.ViewEngines.Insert(0, new CustomViewEngine());
});

var app = builder.Build();

// ������������� ������������� ��������� � �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
