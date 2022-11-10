using Ch11_02_Sorting.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connection = "Server=DARK\\SQLEXPRESS;Database=userstoredb;Trusted_Connection=True;TrustServerCertificate=True;";
    
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
