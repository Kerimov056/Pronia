using Pronia.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Core.Entities;

public class NewProduct : IEntity
{
    public int Id { get ; set ; }
    public string MainImage { get; set; } = null!;
    [Required]
    public string HoverImage { get; set; } = null!;
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    public int Starts { get; set; }

}
