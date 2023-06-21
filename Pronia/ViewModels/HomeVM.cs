using Pronia.Core.Entities;
using Pronia.Core.Entitiesş;

namespace Pronia.ViewModels;

public class HomeVM
{
    public IEnumerable<Slidaer> Slidaers { get; set; }  
    public IEnumerable<Payment> Payments { get; set; }  

}
