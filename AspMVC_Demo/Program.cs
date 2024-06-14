using AspMVC_Demo.BLL.InterfaceService;
using AspMVC_Demo.BLL.Service;
using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.DAL.Repositories;
using Microsoft.Data.SqlClient;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IContactRepositories, ContactRepositorie>();
builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(@"Server=GOS-VDI201\TFTIC;Database=AspMVC_Demo;Trusted_Connection=True;TrustServerCertificate=true"));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
