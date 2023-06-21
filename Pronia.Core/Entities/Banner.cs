using Pronia.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Core.Entitiesı
{
    public class Banner : IEntity
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        public string Name { get; set; } = null!;
        [Required, MaxLength(120)]
        public string Description { get; set; } = null!;
        [Required,MaxLength(300)]
        public string ImagePath { get; set; } = null!;
    }
}
