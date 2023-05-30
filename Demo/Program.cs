using Microsoft.EntityFrameworkCore;
using net60_react.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CodeDemoContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("connectionvalue"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("/products","/products.html");
app.MapFallbackToFile("/products","/coreitems.html");
app.MapFallbackToFile("/products/{pId}","/products/[productId].html");
app.MapFallbackToFile("index.html");

app.Run();
