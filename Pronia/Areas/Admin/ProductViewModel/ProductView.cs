using Microsoft.Build.Framework;

namespace Pronia.Areas.Admin.ProductViewModel;

public class ProductView
{
    [Required]
    public IFormFile MImage { get; set; } = null!;
    [Required]
    public IFormFile HImage { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Starts { get; set; } 
}
