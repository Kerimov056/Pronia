using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DataAccess.Database;
using Pronia.ViewModels;

namespace Pronia.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        HomeVM homeVm = new()
        {
            Slidaers = await _context.slidaers.ToListAsync(),
            Payments = await _context.payments.ToListAsync(),
            Products = await _context.products.ToListAsync(),
            Banners = await _context.banners.ToListAsync() ,
            NewProducts = await _context.newproducts.ToListAsync(),
            Testimonial = await _context.testimonial.ToListAsync()
        };
        return View(homeVm);
    }
}
