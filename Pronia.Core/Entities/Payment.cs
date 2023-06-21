using Pronia.Core.Interfaces;

namespace Pronia.Core.Entitiesş
{
    public class Payment : IEntity
    {
        public int Id { get ; set ; }
        public string Title { get ; set ; }
        public string Description { get ; set ; }
    }
}
