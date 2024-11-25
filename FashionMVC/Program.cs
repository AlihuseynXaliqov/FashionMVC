using FashionMVC.DAL;
using Microsoft.EntityFrameworkCore;

namespace FashionMVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer( builder.Configuration.GetConnectionString("default")));
        
        var app = builder.Build();

        app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
        app.UseStaticFiles();
        

        app.Run();
    }
}