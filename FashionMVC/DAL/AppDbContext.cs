using FashionMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FashionMVC.DAL;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Products> Products { get; set; }
    public DbSet<Sliders> Sliders { get; set; }
}