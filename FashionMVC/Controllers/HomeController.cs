using FashionMVC.DAL;
using FashionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FashionMVC.Controllers;

public class HomeController: Controller
{
    private AppDbContext _appDbContext;

    public HomeController(AppDbContext appDbContext)
    {
        _appDbContext=appDbContext;
    }
    
    public IActionResult Index()
    {
       List<Products> productsList = _appDbContext.Products.ToList();
       List<Sliders> slidersList = _appDbContext.Sliders.ToList();
       _appDbContext.SaveChanges();

       ModelList slidersModel = new ModelList()
       {
          products = productsList,
          sliders = slidersList
       };
       return View(slidersModel);
    }
}