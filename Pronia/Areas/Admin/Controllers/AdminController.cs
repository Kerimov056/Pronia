using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Areas.Admin.ProductViewModel;
using Pronia.Core.Entities;
using Pronia.DataAccess.Database;

namespace Pronia.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminController : Controller
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public AdminController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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

    public IActionResult Create(ProductView product_view)
    {
        if (ModelState.IsValid)
        {
            var product = _mapper.Map<Product>(product_view);
            _context.products.Add(product);
            _context.SaveChanges(); 
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Edit(int id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var product = _context.products.Find(id);
        if (product is null)
        {
            return NotFound();
        }
        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Delete(int id)
    {
        var product = _context.products.Find(id);
        if (product is null)
        {
            return NotFound();
        }
        return View();
    }
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int id)
    {
        var product = _context.products.Find(id);
        if (product is null)
        {
            return NotFound();
        }
        _context.products.Remove(product);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
