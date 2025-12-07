using System.Reflection;
using Foodish.BusinessLayer.Abstract;
using Foodish.BusinessLayer.Concrete;
using Foodish.DataAccessLayer.Abstract;
using Foodish.DataAccessLayer.Context;
using Foodish.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoodishContext>();

builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();


builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ISliderDal,EFSliderDal>();
builder.Services.AddScoped<ISliderService,SliderManager>();

builder.Services.AddScoped<IAboutItemDal, EFAboutItemDal>();
builder.Services.AddScoped<IAboutItemService, AboutItemManager>();

builder.Services.AddScoped<IReviewDal, EFReviewDal>();
builder.Services.AddScoped<IReviewService, ReviewManager>();


builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IAboutDal, EFAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStatusCodePages(async x =>
 {
     if (x.HttpContext.Response.StatusCode == 404)
     {
         x.HttpContext.Response.Redirect("/ErrorPage/ErrorPage404");
     }
 });

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
