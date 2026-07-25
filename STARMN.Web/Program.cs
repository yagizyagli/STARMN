using Microsoft.EntityFrameworkCore;
using STARMN.Access.Repositories;
using STARMN.Access.Repositories.Interfaces;
using STARMN.Database;
using STARMN.Service.Services;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Web;
   
public class Program
{
        public static void Main(string[] args)
        {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var connectionAddress = builder.Configuration.GetConnectionString("STARMNDBConnection");
        builder.Services.AddSqlServer<STARMNDB>(connectionAddress);


        // Add services and repositories to the DI container
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IBasketService, BasketService>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IRoleService,RoleService>();


        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IBasketRepository, BasketRepository>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IRoleRepository, RoleRepository>();
        builder.Services.AddHttpContextAccessor();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();


        app.MapAreaControllerRoute(
              name: "areas",
              areaName: "AdminPanel",
              pattern: "AdminPanel/{controller=Home}/{action=Index}/{id?}")
              .WithStaticAssets();


        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Anasayfa}/{action=Index}/{id?}")
            .WithStaticAssets();


        app.Run();
    
    }
}



