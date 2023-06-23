using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;
using Pronia.DataAccess.Database;

namespace Pronia.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminController : Controller
{
    private readonly AppDbContext _context;

    public AdminController(AppDbContext context)
    {
            _context= context;
    }
    public async Task<IActionResult> Index()
    {
        return View(await _context.products.ToListAsync());
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]

    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.products.Add(product);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        return View();
    }
}
