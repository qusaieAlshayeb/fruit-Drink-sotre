using fruitDrink.Data.RealRepoistry;
using fruitDrink.Data;

using fruitDrink.Models;
using fruitDrink.Models.interfaces;
using fruitDrink.Models.Mocks;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.AspNetCore.Mvc;
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Services

builder.Services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();



builder.Services.AddScoped<IDrinkReporistry, DrinkRepositors>();
builder.Services.AddTransient<ICategoryRepoistry,MockCategoryReporistry>();
builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
builder.Services.AddScoped<IOrderRepoistry,OrderRepoistry>();
builder.Services.AddScoped(shop => ShoppingCart.GetCart(shop));
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
builder.Services.AddMemoryCache();
builder.Services.AddControllers(
    options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

builder.Services.AddSession();

#endregion


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseRouting();


app.UseSession();

app.UseStaticFiles();
app.UseAuthorization();

app.UseAuthentication();


app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    
    

   );

app.UseMvc(routes =>
{

    routes.MapRoute(
        name: "categoryfilter",
        template: "Drink/{action}/{Category?}",
        defaults: new { Controller = "Drink", action = "List" });

});
DbInitailizer.Seed(app);

app.Run();
