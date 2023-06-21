using Pronia.Core.Interfaces;

namespace Pronia.Core.Entities;

public class Slidaer : IEntity
{
    public int Id { get; set; } 
    public string Name { get; set; } = null!;
    public string Offer { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ImagePath { get; set; } = null!;

}
